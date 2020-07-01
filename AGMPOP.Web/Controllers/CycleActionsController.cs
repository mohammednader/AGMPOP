using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models.Cycle;
using AGMPOP.Web.Models.Notifications;
using AGMPOP.Web.Models.Transaction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class CycleActionsController : BaseController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Notify Notify;
        public CycleActionsController(IUnitOfWork UnitofWork, Notify notify)
        {
            unitOfWork = UnitofWork;
            Notify = notify;
        }

        #region CycleIndex
        public IActionResult CycleIndex()
        {
            return View();
        }

        [PermissionNotRequired]
        public JsonResult GetCycle()
        {
            var now = DateTime.Now;
            var ResultData = unitOfWork.CycleUserBL.GetCycleById(cu =>
                                                                      cu.Cycle.IsActive == true &&
                                                                      cu.Cycle.StartDate <= now &&
                                                                      cu.Cycle.EndDate >= now &&
                                                                      cu.Cycle.Department.IsActive == true &&
                                                                      cu.UserId == LoggedUserId)
                                                    .ToList();
            return Json(new { message = "success", data = ResultData });

        }
        #endregion

        #region CycleDetails
        public IActionResult CycleTransaction()
        {
            return View();
        }

        [PermissionNotRequired]
        public JsonResult GetUserCycleById(int cycleId)
        {

            var ResultData = unitOfWork.CycleUserBL.GetCycleById(u => u.UserId == LoggedUserId && u.CycleId == cycleId).FirstOrDefault();

            return Json(new
            {
                Ok = true,
                data = ResultData,
                Remaining = GetCurrentAvailableQuantity(cycleId),
                HrCount = GetHRCountByCycle(cycleId)
            });

        }

        [PermissionNotRequired]
        public JsonResult GetTransactionCycleById(int cycleId)
        {
            var data = unitOfWork.TransactionBL
                                        .GetAllTransactionAPI(u => (u.FromUserId == LoggedUserId ||   u.ToUserId == LoggedUserId) 
                                        && u.CycleId == cycleId)
                                       .ToList();
            return Json(new { message = "success", data = data });

        }

        [PermissionNotRequired]
        public JsonResult GetHRCountByCycle(int cycleId)
        {
            var data = unitOfWork.CycleUserBL.GetUserCycle(c => c.CycleId == cycleId && c.User.JobTitle.JobTitleId == (int)POPEnums.JobTitle.HeadRunner).Count;
            return Json(new { message = "success", data = data });
        }

        #endregion

        #region actions
        public ActionResult NewTransaction()
        {

            return View("NewDelivery");
        }

        [PermissionNotRequired]
        public JsonResult GetUsersAction(int cycleid, int actionId)
        {

            List<UserDetailsDto> Cycleusers = new List<UserDetailsDto>();

            // get all hr 
            Cycleusers = unitOfWork.CycleUserBL.GetUserCycle(cu => cu.CycleId == cycleid && cu.UserId != LoggedUserId);

            // in case of hr return to bbx 
            if (actionId == (int)TransactionTypes.Return)
            {
                Cycleusers = Cycleusers.Where(u => u.JobTitleName.ToLower() == "bbx").ToList();
            }
            else
            {
                Cycleusers = Cycleusers.Where(u => u.JobTitleName.ToLower() == "hr").ToList();

            }
            if (Cycleusers != null)
            {
                return Json(new
                {
                    data = Cycleusers,
                    Remaining = GetCurrentAvailableQuantity(cycleid)
                });
            }

            return Json(null);
        }

        public object GetCurrentAvailableQuantity(int cycleId)
        {
            var userTtile = ((ClaimsIdentity)User?.Identity)?.FindFirst("JobTitle").Value ?? string.Empty;

            if (!string.IsNullOrEmpty(userTtile) && userTtile.ToLower() == "bbx")
            {
                var products = unitOfWork.CycleProductBL.GetCycleProduct(c => c.CycleId == cycleId).ToList();
                var total = products.Sum(p => p.Quantity);
                var RemainingQuant = products.Sum(p => p.RemainingQuant);
                return new
                {
                    TotalItems = total,
                    RemainingItems = RemainingQuant
                };

            }
            else if (!string.IsNullOrEmpty(userTtile) && userTtile.ToLower() == "hr")
            {
                var products = unitOfWork.UserClearanceBL.Find(u => u.UserId == LoggedUserId && u.CycleId == cycleId).ToList();
                var total = products.Sum(p => p.TotalQuantity);
                var RemainingQuant = products.Sum(p => p.ClearanceQuantity);
                return new
                {
                    TotalItems = total,
                    RemainingItems = RemainingQuant
                };
            }
            else return null;
        }

        [PermissionNotRequired]
        public JsonResult GetTransactionDetails(int cycleId, int TransID)
        {
            var model = unitOfWork.TransactionDetailsBL.GetAllTransDetails(f => f.TransactionId == TransID).Select(f => new TransactionNotifcation
            {
                ProductId = f.ProductId,
                ProductName = f.Product.Name,
                ProductImg = f.Product.Image,
                Code = f.Product.Code,
                Quantity = f.TransAmount,
               // TypeName = f.Product.TypeId == 1 ? ProductType.BBO.ToString() : ProductType.Product.ToString(),
            }).ToList();
            if (model != null)
            {
                return Json(new { data = model });

            }
            return Json(null);
        }

        [PermissionNotRequired]
        public JsonResult GetUserClearanceProducts(int cycleId)
        {
            var UserClearance = unitOfWork.UserClearanceBL
                                                .GetAllWithDetails(c => c.CycleId == cycleId && c.UserId == LoggedUserId)

                .Select(f => new TransactionNotifcation
                {
                    ProductId = f.ProductId,
                    ProductName = f.Product.Name,
                    ProductImg = f.Product.Image,
                    Code = f.Product.Code,
                    Quantity = f.ClearanceQuantity.GetValueOrDefault(),
                   // TypeName = f.Product.TypeId == 1 ? ProductType.BBO.ToString() : ProductType.Product.ToString(),
                }).ToList();
            if (UserClearance != null)
            {
                return Json(new { data = UserClearance });

            }
            return Json(null);
        }

        [HttpPost]
        public JsonResult NewTransaction([FromBody] TransactionDto data)
        {
            try
            {
                List<TransactionProduct> Items = data.transaction_items;
                int CId = int.Parse(data.cycle_id.ToString());
                int TOUId = int.Parse(data.to_user_id.ToString());
                int ActionId = int.Parse(data.action_id.ToString());


                var UserJobTitle = unitOfWork.AppUserBL.GetUserWithJobTitle(LoggedUserId).JobTitle.Name.ToLower();

                List<TransactionDetail> TranDetList = new List<TransactionDetail>();
                List<InventoryLog> LogTransList = new List<InventoryLog>();
                List<Notifications> Notification = new List<Notifications>();
 
                foreach (var item in Items)
                {
                    int prodid = int.Parse(item.productId.ToString());
                    if (item.count < 1) continue;

                    #region Update Clearance dependant on userJobTitle
                    if (UserJobTitle == "bbx")
                    {
                        // no delivery for bbx till now  24 /02 /2020 

                        //  unitOfWork.UserClearanceBL.UpdateUserClearance(LoggedUserId, CId, prodid, item.count);
                    }
                    else
                    {
                        unitOfWork.UserClearanceBL.UpdateUserClearance(LoggedUserId, CId, prodid, -item.count, true);
                    }

                    #endregion

                    TransactionDetail NewTranDet = new TransactionDetail()
                    {
                        ProductId = prodid,
                        TransAmount = item.count
                    };
                    TranDetList.Add(NewTranDet);
                }

                #region Add Notification

                Notification.Add(new Notifications
                {
                    CreatedAt = DateTime.Now,
                    Title = NotificationType.Unconfirmed.ToString(),
                    Notificationtype = (int)POPEnums.NotificationType.Unconfirmed,
                    IsSeen = false,
                    ToUserId = TOUId
                });
                #endregion


                Transaction NewTransObj = new Transaction()
                {

                    CreateDate = System.DateTime.Now,
                    CycleId = CId,
                    CreatedById = LoggedUserId,
                    Status = (int)POPEnums.TransactionStatus.Pending,
                    TransType = ActionId,  // deliver / return / transfer 
                    FromUserId = LoggedUserId,
                    ToUserId = TOUId,
                    TransactionDetail = TranDetList,
                    Notifications = Notification
                    //   FromTerritoryId = FromTerritory.TerritoryId,
                    // ToTerritoryId = toTerritory.TerritoryId
                };

                unitOfWork.TransactionBL.Add(NewTransObj);

                try
                {
                    if (unitOfWork.Complete(LoggedUserId) > 0)
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

        #endregion


        #region Notifications

        public IActionResult Notifications()
        {
            return View();
        }

        [PermissionNotRequired]
        public IActionResult ConfirmTransaction(int CycleId)
        {
            // get transaction to current user and confirmed 
            // if not found >> this is first trans 
            var trans = unitOfWork.TransactionBL
                                  .Find(f => f.ToUserId == LoggedUserId &&
                                                                f.Status == (int)POPEnums.TransactionStatus.Confirmed &&
                                                                f.CycleId == CycleId);

            var currentUserJobTitle = ((ClaimsIdentity)User.Identity)?.FindFirst("JobTitle").Value ?? string.Empty;
            if (trans.Count != 0 && currentUserJobTitle.ToLower() != "bbx")
            {
                ViewBag.FirstForm = true;

            }
            else
            {
                ViewBag.FirstForm = false;
            }

            return View();
        }


        [PermissionNotRequired]
        public IActionResult NotificationDetails()
        {
            return View("NotificationDetails");
        }


        [PermissionNotRequired]
        public JsonResult notificationsList()
        {

            try
            {
                //  var model = unitOfWork.NotificationsBL.GetAllDetailsForUser(LoggedUserId);

                var model = unitOfWork.NotificationsBL.GetAllDetailsForUser(LoggedUserId).Select(f => new NotificationVM
                {
                    Id = f.Id,
                    TransactionId = f.TransactionId.GetValueOrDefault(),
                    CycleId = f.Transaction.CycleId.GetValueOrDefault(),
                    Title = f.Title,
                    Message = f.Message,
                    UserName = f.ToUser.FullName,
                    Notificationtype = f.Notificationtype,
                    createdAt = f.CreatedAt.GetValueOrDefault(),
                    IsSeen = f.IsSeen,
                    SeenDate = f.SeenDate,
                    CycleName = f.Transaction.Cycle?.Name
                }).OrderByDescending(n => n.Id).ToList();
                if (model != null)
                {
                    return Json(model);


                }

            }
            catch (Exception)
            {
                return Json(null);
            }
            return Json(null);


        }



        [PermissionNotRequired]
        public JsonResult GetCycleName(int cycleId)
        {
            try
            {
                var model = unitOfWork.CyclesBL.Find(f => f.CycleId == cycleId).Select(f => new CycleVM
                {
                    CycleId = f.CycleId,
                    Name = f.Name,
                    CycleType = f.Type,
                    StartDate = f.StartDate,
                    EndDate = f.EndDate,
                }).FirstOrDefault();
                if (model != null)
                {
                    return Json(model);

                }

            }
            catch (Exception ex)
            {

            }
            return Json(null);

        }

        [PermissionNotRequired]
        public JsonResult GetCycleDetalis(int cycleId, int TransID)
        {
            try
            {
                var model = unitOfWork.NotificationsBL.GetCycleDetalis(TransID);
                var res = new NotificationCycleDetails()
                {
                    FromUserName = model.FromUser.JobTitle.Name,
                    ToUserName = model.ToUser.JobTitle.Name,
                    AllItems = model.TransactionDetail.Sum(f => f.TransAmount),

                };
                if (model != null)
                {
                    return Json(res);

                }
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
            return Json(null);

        }

        // not compeleted
        [HttpPost]
        public JsonResult UpdateNotification(ClearnceDTo clearnceData)
        {
            try
            {
                List<InventoryLog> LogTransList = new List<InventoryLog>();
                List<TransactionProduct> ClearanceItems = clearnceData.transaction_items;
                List<TransactionDetail> TranDetList = new List<TransactionDetail>();

                List<UserClearance> userClearanceList = new List<UserClearance>();

                // get form 2 quntity
                var transPrductsQnty = unitOfWork.TransactionDetailsBL.Find(f => f.TransactionId == clearnceData.TransactionId).ToList();

                var userJob = unitOfWork.AppUserBL.GetUserWithJobTitle(LoggedUserId);

                if (userJob.JobTitle.Name.ToLower() == "bbx")
                {
                    var TransModel = unitOfWork.TransactionBL.Find(f => f.TransactionId == clearnceData.TransactionId).FirstOrDefault();
                    var NotifiModel = unitOfWork.NotificationsBL.Find(f => f.Id == clearnceData.NotificationId).FirstOrDefault();
                    var CycleProducts = unitOfWork.CycleProductBL.Find(cp => cp.CycleId == clearnceData.cycle_id).ToList();

                    // new system tranaction from bbx to hr and here bbx will confirm it and add item to the cycle 
                    if (TransModel.FromUserId == LoggedUserId && TransModel.TransType == (int)TransactionTypes.Delivery)
                    {
                        #region  update notifications and add notification to next user  
                        NotifiModel.Title = NotificationType.Confirmed.ToString();
                        NotifiModel.Notificationtype = (int)NotificationType.Confirmed;
                        unitOfWork.NotificationsBL.Update(NotifiModel);

                        // make trans pending
                        TransModel.Status = (int)TransactionStatus.Pending;
                        TransModel.ModifiedDate = DateTime.Now;

                        unitOfWork.TransactionBL.Update(TransModel);

                        var NewNotif = new Notifications()
                        {
                            TransactionId = clearnceData.TransactionId,
                            ToUserId = TransModel.ToUserId,
                            Notificationtype = (int)NotificationType.Unconfirmed,
                            Title = NotificationType.Unconfirmed.ToString(),
                            CreatedAt = DateTime.Now,

                        };
                        unitOfWork.NotificationsBL.Add(NewNotif);

                        #endregion

                        for (int i = 0; i < transPrductsQnty.Count; i++)
                        {
                            var prod = transPrductsQnty[i];
                            var cycleprod = CycleProducts.FirstOrDefault(p => p.ProductId == prod.ProductId);
                            if (cycleprod != null)
                            {
                                cycleprod.Qunt += prod.TransAmount;
                                // cycleprod.RemainQunt -= prod.TransAmount;
                                unitOfWork.CycleProductBL.Update(cycleprod);
                            }
                            else
                            {
                                CycleProduct newProduct = new CycleProduct();
                                newProduct.CycleId = clearnceData.cycle_id;
                                newProduct.ProductId = prod.ProductId;
                                newProduct.Qunt = prod.TransAmount;
                                //  newProduct.RemainQunt = prod.TransAmount;
                                unitOfWork.CycleProductBL.Add(newProduct);
                            }

                        }
                    }
                    // return tranaction from hr to current bbx user 
                    else if (TransModel.ToUserId == LoggedUserId && TransModel.TransType == (int)TransactionTypes.Return)
                    {
                        #region  update notifications and add notification to next user  

                        NotifiModel.Title = NotificationType.Confirmed.ToString(); ;
                        NotifiModel.Notificationtype = (int)NotificationType.Confirmed;
                        unitOfWork.NotificationsBL.Update(NotifiModel);
                        // make trans pending
                        TransModel.Status = (int)TransactionStatus.Confirmed;
                        TransModel.ModifiedDate = DateTime.Now;
                        unitOfWork.TransactionBL.Update(TransModel);

                        #endregion
                        var inventoryLogs = new List<InventoryLog>();
                        var allProducts = unitOfWork.ProductBL.GetAll();
                        for (int i = 0; i < transPrductsQnty.Count; i++)
                        {
                            var prod = transPrductsQnty[i];

                            #region update cycle prod 
                            var cycleprod = CycleProducts.FirstOrDefault(p => p.ProductId == prod.ProductId);
                            cycleprod.Qunt -= prod.TransAmount;
                            unitOfWork.CycleProductBL.Update(cycleprod);
                            #endregion

                            var product = allProducts.FirstOrDefault(p => p.ProductId == prod.ProductId);
                            var availableQuanity = product.InventoryQnty ?? 0;
                            if (product != null)
                            {
                                product.InventoryQnty += prod.TransAmount;
                                unitOfWork.ProductBL.Update(product);
                                inventoryLogs.Add(new InventoryLog
                                {
                                    ProductId = prod.ProductId,
                                    OldQnty = availableQuanity,
                                    NewQnty = availableQuanity + prod.TransAmount,
                                    Quantity = prod.TransAmount,
                                    TransactionType = (int)TransactionTypes.Return,
                                    UserId = LoggedUserId,
                                    CreatedDate = DateTime.Now,
                                    ActionType = (int)InventoryActionType.Increment,
                                    TransactionId = TransModel.TransactionId
                                });
                            }
                        }

                        unitOfWork.InventoryLogBL.AddRange(inventoryLogs);
                    }


                    if (unitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { Success = true, Message = "Confirmed" });
                    }

                }

                if (userJob.JobTitle.Name.ToLower() == "hr")
                {
                    var NotifiModel = unitOfWork.NotificationsBL.Find(f => f.Id == clearnceData.NotificationId).FirstOrDefault();
                    NotifiModel.Title = NotificationType.Confirmed.ToString(); ;
                    NotifiModel.Notificationtype = (int)NotificationType.Confirmed;
                    unitOfWork.NotificationsBL.Update(NotifiModel);

                    var TransModel = unitOfWork.TransactionBL.Find(f => f.TransactionId == clearnceData.TransactionId).FirstOrDefault();
                    TransModel.Status = (int)TransactionStatus.Confirmed;
                    TransModel.ConfirmDate = DateTime.Now;
                    unitOfWork.TransactionBL.Update(TransModel);

                    // if first form is empty add second form to omar table
                    // clearance items 


                    var AllProductsList = transPrductsQnty.Select(q => new TransactionProduct(q)).ToList();
                    // prev tranaction is not null  so htere is a clearance for this user 
                    if (ClearanceItems != null)
                    {
                        AllProductsList = ClearanceItems.Concat(transPrductsQnty.Select(q => new TransactionProduct(q)))
                                                         .GroupBy(x => x.productId, x => x.count,
                                                                   (id, counts) => new TransactionProduct
                                                                   {
                                                                       productId = id,
                                                                       count = counts.Sum()
                                                                   }).ToList();



                    }

                    for (int i = 0; i < AllProductsList.Count; i++)
                    {
                        var prod = AllProductsList[i];
                        int NewQunatity = transPrductsQnty.Where(t => t.ProductId == prod.productId).Sum(t => t.TransAmount);
                        // add new quntity to totlal &  overwrite clreance quntity 
                        unitOfWork.UserClearanceBL.OverwriteUserClearance(LoggedUserId, clearnceData.cycle_id, prod.productId, prod.count, NewQunatity);



                        //// if producthas clearcne and is not exists in new tranaction 
                        //if (ClearanceItems != null && ClearanceItems.Any(p => p.productId == prod.productId) && !transPrductsQnty.Any(p => p.ProductId == prod.productId))
                        //{
                        //    unitOfWork.UserClearanceBL.UpdateUserClearance(LoggedUserId, clearnceData.cycle_id, prod.productId, prod.count);
                        //}
                        //else //if (ClearanceItems != null && ClearanceItems.Any(p => p.productId == prod.productId) && transPrductsQnty.Any(p => p.ProductId == prod.productId))
                        //{
                        //    int NewQunatity = transPrductsQnty.Where(t => t.ProductId == prod.productId).Sum(t => t.TransAmount);
                        //    // add new quntity to totlal &  overwrite clreance quntity 
                        //    unitOfWork.UserClearanceBL.OverwriteUserClearance(LoggedUserId, clearnceData.cycle_id, prod.productId, prod.count, NewQunatity);
                        //}


                    }
                    if (unitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { Success = true, Message = "Confirmed" });
                    }

                }

            }
            catch (Exception)
            {
                return Json(new { Success = false, Message = "There is an error" });
            }
            return Json(new { Success = false, Message = "There is an error" });
        }

        [PermissionNotRequired]
        public JsonResult SeenAt(int notificationId)
        {
            try
            {
                var model = unitOfWork.NotificationsBL.Find(f => f.Id == notificationId).FirstOrDefault();
                if (model != null && model.IsSeen != true)
                {
                    model.SeenDate = DateTime.Now;
                    model.IsSeen = true;
                    unitOfWork.NotificationsBL.Update(model);
                    if (unitOfWork.Complete(LoggedUserId) > 0)
                    {
                        var Count = unitOfWork.NotificationsBL.GetCountUnSeenNotification(LoggedUserId);
                        _ = Notify.UpdateUnseenCount(LoggedUserId, Count);
                        return Json(new { Success = true, Message = "Seen" });
                    }
                    else
                    {
                        return Json(new { Success = true, Message = "Seen" });
                    }
                }

            }

            catch (Exception)
            {

                return Json(new { Success = false, Message = "There is an error" });

            }
            return Json(new { Success = false, Message = "There is an error" });

        }
        #endregion


    }


}