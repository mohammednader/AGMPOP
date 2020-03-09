using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models;
using AGMPOP.Web.Models.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class TransactionController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;

        public TransactionController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IActionResult NewTransaction()
        {

            //Check  Auth
            try
            {
                //var now = DateTime.Today;

                ////Get Cycles for this transaction
                //NewTransactionVM trans = new NewTransactionVM();

                //if (LoggedIsSystemAdmin)
                //{
                //    trans.CycleList = UnitOfWork.CyclesBL.Find(c => c.Status == (int)POPEnums.CycleStatus.New &&
                //                                               c.IsActive == true && c.StartDate <= now &&
                //                                               c.EndDate >= now && c.ReconciliationDate >= now
                //                                               && c.Department.IsActive == true
                //                                              ).Select(c => new SelectListItem { Text = c.Name, Value = c.CycleId.ToString() })
                //                                               .ToList();
                //}
                //else // normal user 
                //{
                //    trans.CycleList = UnitOfWork.CyclesBL.Find(c => c.Status == (int)POPEnums.CycleStatus.New &&
                //                                               c.IsActive == true && c.StartDate <= now &&
                //                                               c.EndDate >= now && c.ReconciliationDate >= now &&
                //                                               c.DepartmentId == LoggedUserDepartmentId
                //                                               ).Select(c => new SelectListItem { Text = c.Name, Value = c.CycleId.ToString() })
                //                                               .ToList();
                //}
                //return View(trans);
                   return View();
            }
            catch (Exception e)
            {
                return View();
            }
        }

        [PermissionNotRequired]
        public JsonResult UserCycle(int CycleId)
        {
            try
            {
                var usersCycle = UnitOfWork.CycleUserBL.GetUserCycle(c => c.CycleId == CycleId && c.User.JobTitle.Name.ToLower() == "hr")
                    .Select(u =>
                      new CycleUsers
                      {
                          Name = u.Name,
                          Id = u.Id
                      }
                    ).ToList();

                // var users = UnitOfWork.AppUserBL.Find(p => usersCycle.Contains(p.Id)).Select(a => new CycleUsers { Name = a.FullName, Id = a.Id }).ToList();

                return Json(new { success = true, data = usersCycle });
            }
            catch (Exception e)
            {
                return Json(new { success = false, message = e.Message });

            }
        }

        [PermissionNotRequired]
        public IActionResult _CycleProductList(int CycleId, bool NewPoduct = false, bool IsRequest = false)
        {
            // check partial: if true go to NewRequest page 
            if (IsRequest == true)
            {
                ViewBag.IsRequest = true;
            }
            // check partial: if false go to Newtransaction page with validation
            else
            {
                ViewBag.IsRequest = false;

            }

            if (NewPoduct == false)
            {
                var cycleProduct = UnitOfWork.CycleProductBL.GetCycleProduct(c => c.CycleId == CycleId && c.Product.InventoryQnty > 0);
                return PartialView(cycleProduct);
            }
            else
            {
                var cycleProductId = UnitOfWork.CycleProductBL.Find(c => c.CycleId == CycleId).Select(c => c.ProductId);
                var NewProducts = UnitOfWork.ProductBL
                                                        .Find(p => p.IsActive == true &&
                                                                     !cycleProductId.Contains(p.ProductId) &&
                                                                     p.DepartmentId == LoggedUserDepartmentId &&
                                                                     p.InventoryQnty > 0)

                                                      .Select(c => new ProductCycleModel
                                                      {
                                                          ProductName = c.Name,
                                                          ProductId = c.ProductId,
                                                          ProductImg = c.Image,
                                                         // TypeId = c.TypeId.GetValueOrDefault(),
                                                          InventoryQuantity = Convert.ToInt32(c.InventoryQnty.GetValueOrDefault())
                                                      }).ToList();
                return PartialView(NewProducts);
            }
        }

        [HttpPost]
        public IActionResult NewTransaction(string cycleId, string userId, List<string> Arr)
        {
            try
            {
                List<string> ProductsItems = Arr;
                int CId = int.Parse(cycleId.ToString());
                int UId = int.Parse(userId.ToString());

                var BBxUser = UnitOfWork.CycleUserBL.GetUserCycle(c => c.CycleId == CId && c.User.JobTitle.Name.ToLower() == "bbx").FirstOrDefault();

                if (BBxUser == null)
                {
                    return Json(new { success = false, message = "Transaction Failed : There is no BBx assinged in the cycle" });
                }


                List<TransactionDetail> TranDetList = new List<TransactionDetail>();
                List<InventoryLog> LogTransList = new List<InventoryLog>();
                var notification = new List<Notifications>();

                foreach (var item in ProductsItems)
                {
                    var _arr = item.Split(':').Select(Int32.Parse).ToList();

                    int prodid = _arr[0];
                    if (_arr[1] < 1) continue;
                    var EdProduct = UnitOfWork.ProductBL.Find(p => p.ProductId == prodid).FirstOrDefault();
                    //Log Transaction
                    if (EdProduct != null)
                    {
                        var NewLogTrans = new InventoryLog()
                        {
                            ProductId = prodid,
                            Quantity = _arr[1],
                            UserId = BBxUser.Id,
                            CreatedDate = DateTime.Now,
                            TransactionType = (int)POPEnums.TransactionTypes.Delivery,
                            ActionType = (int)POPEnums.InventoryActionType.Decrement,
                            OldQnty = (int)EdProduct.InventoryQnty,
                            NewQnty = (int)EdProduct.InventoryQnty - _arr[1],
                        };
                        EdProduct.InventoryQnty -= _arr[1];
                        LogTransList.Add(NewLogTrans);

                    }


                    TransactionDetail NewTranDet = new TransactionDetail()
                    {
                        ProductId = prodid,
                        TransAmount = _arr[1]
                    };
                    TranDetList.Add(NewTranDet);

                }
                notification.Add(new Notifications
                {
                    CreatedAt = DateTime.Now,
                    Title = POPEnums.NotificationType.NotConfirmed.ToString(),
                    Notificationtype = (int)POPEnums.NotificationType.NotConfirmed,
                    IsSeen = false,
                    ToUserId = BBxUser.Id
                });
                Transaction NewTransObj = new Transaction()
                {
                    CreateDate = System.DateTime.Now,
                    CycleId = CId,
                    CreatedById = LoggedUserId,
                    Status = (int)POPEnums.TransactionStatus.NewRequst,
                    ToUserId = UId,
                    TransactionDetail = TranDetList,
                    TransType = (int)POPEnums.TransactionTypes.Delivery,
                    FromUserId = BBxUser.Id,
                    InventoryLog = LogTransList,
                    Notifications = notification

                };

                UnitOfWork.TransactionBL.Add(NewTransObj);
                try
                {
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { success = true, message = ApplicationMessages.SaveSuccess });

                    }
                }

                catch { return Json(new { success = false, message = ApplicationMessages.SaveFailed }); }
            }
            catch (Exception e)
            {
                return Json(new { success = false, massege = ApplicationMessages.ErrorOccure });
            }
            return Json(new { success = false });

        }

        public IActionResult CancelTransaction()
        {

            try
            {
                var now = DateTime.Now;

                //Get Cycles for this transaction
                NewTransactionVM trans = new NewTransactionVM();

                if (LoggedIsSystemAdmin)
                {
                    trans.CycleList = UnitOfWork.CyclesBL.Find(c =>  
                                                               c.IsActive == true && c.StartDate <= now &&
                                                               c.EndDate >= now && c.ReconciliationDate >= now
                                                              ).Select(c => new SelectListItem { Text = c.Name, Value = c.CycleId.ToString() })
                                                               .ToList();
                }
                else // normal user 
                {
                    trans.CycleList = UnitOfWork.CyclesBL.Find(c => 
                                                               c.IsActive == true && c.StartDate <= now &&
                                                               c.EndDate >= now && c.ReconciliationDate >= now &&
                                                               c.DepartmentId == LoggedUserDepartmentId
                                                               ).Select(c => new SelectListItem { Text = c.Name, Value = c.CycleId.ToString() })
                                                               .ToList();
                }
                return View(trans);
            }
            catch (Exception e)
            {
                return View();
            }

        }

        [PermissionNotRequired]
        public PartialViewResult _CycleTransaction(int CycleId)
        {
            //Get Transaction status is New request
            try
            {
                if (CycleId != 0)
                {
                    var CycleTransaction = UnitOfWork.TransactionBL.GetCycleTransactions(CycleId)
                                                                   .Where(t => t.Status == (int)POPEnums.TransactionStatus.Pending || t.Status == (int)POPEnums.TransactionStatus.NewRequst)
                                                                   .ToList();

                    return PartialView(CycleTransaction);
                }
                return PartialView();
            }
            catch (Exception e)
            {
                return PartialView(e.Message);

            }
        }

        [PermissionNotRequired]
        public PartialViewResult _TransactionDetails(int Tid)
        {
            try
            {
                var transProductDetails = UnitOfWork.CycleProductBL.GetCycleProductWithDetails(Tid);
                return PartialView(transProductDetails);

            }
            catch (Exception e)
            {
                return PartialView(e.Message);
            }

        }

        [HttpPost]
        public JsonResult CancelTransaction(int TransactionId)
        {
            //Auth Will checked
            if (TransactionId != 0)
            {
                try
                {
                    var currentUserJobTitle = ((ClaimsIdentity)User.Identity)?.FindFirst("JobTitle").Value ?? string.Empty;
                    var Transaction = UnitOfWork.TransactionBL.GetAllTransactionWithDetails(c => c.TransactionId == TransactionId).FirstOrDefault();

                    //var notification = UnitOfWork.NotificationsBL
                    //    .Find(n => n.TransactionId == TransactionId
                    //    && n.Notificationtype == (int)POPEnums.NotificationType.NotConfirmed
                    //    && n.ToUserId == Transaction.from
                    //    ).ToList();
                    // UnitOfWork.NotificationsBL
                    if (Transaction != null)
                    {
                        // decrease inventory 
                        var FromUser = Transaction.FromUser;
                        var FromUserIsBBx = Transaction.FromUser;


                        var transactionDetails = Transaction.TransactionDetail;
                        foreach (var item in transactionDetails)
                        {
                            if (FromUser != null && FromUser.JobTitle.Name.ToLower() == "bbx")
                            {
                                var CycleProd = UnitOfWork.CycleProductBL.FindOne(p => p.CycleId == Transaction.CycleId && p.ProductId == item.ProductId);
                                var EdProduct = UnitOfWork.ProductBL.Find(p => p.ProductId == CycleProd.ProductId).FirstOrDefault();
                                if (EdProduct != null)
                                {
                                    var NewLogTrans = new InventoryLog()
                                    {
                                        TransactionId = item.TransactionId,
                                        ProductId = EdProduct.ProductId,
                                        OldQnty = (int)EdProduct.InventoryQnty,
                                        UserId = FromUser.Id,
                                        CreatedDate = DateTime.Now,
                                        TransactionType = (int)POPEnums.TransactionTypes.Clearance,
                                        ActionType = (int)POPEnums.InventoryActionType.Increment,
                                        Quantity = item.TransAmount,
                                        NewQnty = (int)EdProduct.InventoryQnty + item.TransAmount,
                                    };
                                    EdProduct.InventoryQnty += item.TransAmount;
                                    UnitOfWork.ProductBL.Update(EdProduct);
                                    UnitOfWork.InventoryLogBL.Add(NewLogTrans);
                                }
                                // will take effect when request approved 
                                //if (CycleProd.Qunt > 0) CycleProd.Qunt -= item.TransAmount;
                                //if (CycleProd.RemainQunt > 0) CycleProd.RemainQunt -= item.TransAmount;
                            }
                            else if (FromUser != null && FromUser.JobTitle.Name.ToLower() == "hr")
                            {
                                UnitOfWork.UserClearanceBL.UpdateUserClearance(FromUser.Id, (int)Transaction.CycleId, item.ProductId, item.TransAmount, true);
                            }
                            else return Json(new { success = false, message = "No users found for this transaction" }); ;


                        }
                        Transaction.Status = (int)POPEnums.TransactionStatus.Canceled;
                        Transaction.ModifiedDate = System.DateTime.Now;
                        Transaction.ModfiedById = LoggedUserId;

                        if (UnitOfWork.Complete(LoggedUserId) > 0)
                        {
                            return Json(new { success = true, message = "Transaction deleted Successfully" });
                        }
                        else
                        {
                            return Json(new { success = false, message = "Transaction dosn't Cancel Successfully" });

                        }
                    }
                    else
                    {
                        return Json(new { success = false, message = "Transaction Not Found" });

                    }
                }
                catch
                {
                    return Json(new { success = false, message = ApplicationMessages.ErrorOccure });

                }


            }
            else
            {
                return Json(new { success = false, message = ApplicationMessages.ErrorOccure });
            }

        }


    }
}




