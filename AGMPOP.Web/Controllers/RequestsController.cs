using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using AGMPOP.Web.Models.Requests;
using Microsoft.AspNetCore.Mvc;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class RequestsController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;

        public RequestsController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }



        #region Index


        public IActionResult Index()
        {
            return View();
        }

        [PermissionNotRequired]
        public PartialViewResult PartialRequests()
        {

            try
            {

                List<Request> Result = null;
                if (LoggedIsSystemAdmin)
                {
                    Result = UnitOfWork.RequestsBL.GetAllRequests(r=>r.Cycle.Department.IsActive==true)
                        .OrderByDescending(f => f.CreateDate)
                                        .ToList();
                }
                else // normal user 
                {
                    
                    Result = UnitOfWork.RequestsBL
                                        .GetAllRequests(f => f.CreatedById == LoggedUserId 
                                                            && f.Cycle.DepartmentId == LoggedUserDepartmentId)
                                        .OrderByDescending(f=>f.CreateDate)
                                        .ToList();

                }


                if (Result?.Count() != 0)
                {
                    return PartialView("_PartialRequests", Result);

                }
                else
                {
                    return PartialView("_PartialRequests", null);

                }
            }
            catch (Exception ex)
            {

                return PartialView("_PartialRequests", ex);
            }

        }

        #endregion

        #region GetRequestDetails

        #region get all hr on cycle

        [PermissionNotRequired]
        public JsonResult getCycleHrUser(int ReqID)
        {
            var CycleId = UnitOfWork.RequestsBL
                                            .Find(f => f.RequestId == ReqID)
                                            .Select(f => f.CycleId).FirstOrDefault()
                                                                                      .GetValueOrDefault();
            var model = UnitOfWork.CyclesBL.GetUserCyclesUserByJobName(CycleId, "hr")
                                                          .Select(f => new UserDetailsDto
                                                          {
                                                              Id = f.UserId,
                                                              Name = f.User.FullName,
                                                              JobTitleName = f.User.JobTitle.Name,
                                                          });
            if (model != null)
            {
                return Json(model);
            }
            return Json(null);

        }
        #endregion

        [PermissionNotRequired]
        public JsonResult GetRequestDetails(int RequestId)
        {
            try
            {
                var productModel = UnitOfWork.RequestsBL.GetRequestDetails(f => f.RequestId == RequestId)
                    .Select(f => new ProRequestVM
                    {
                        ProductName = f.Product.Name,
                        RequestAmount = f.RequestAmount.GetValueOrDefault(),
                        ProductId = f.ProductId.GetValueOrDefault(),
                        CycleName = f.Request.Cycle.Name,
                         CycleId = f.Request.Cycle.CycleId,

                        InventoryQuantity = f.Product.InventoryQnty.GetValueOrDefault(),


                    }).ToList();

                var CycleId = UnitOfWork.RequestsBL
                                           .Find(f => f.RequestId == RequestId)
                                           .Select(f => f.CycleId).FirstOrDefault()
                                                                                     .GetValueOrDefault();
                var hrModel = UnitOfWork.CyclesBL.GetUserCyclesUserByJobName(CycleId, "hr")
                                                              .Select(f => new UserDetailsDto
                                                              {
                                                                  Id = f.UserId,
                                                                  Name = f.User.FullName,
                                                                  JobTitleName = f.User.JobTitle.Name,
                                                              }).ToList();


                if (hrModel?.Count > 0 && productModel?.Count > 0)
                {
                    return Json(new { hrModel, productModel });

                }
                else
                {
                    return Json(null);

                }
            }
            catch (Exception ex)
            {

                return Json(ex);
            }



        }

        #endregion

        #region RequestUserCycle //get cycle name and id for dropdownlist


        //public JsonResult RequestUserCycle()
        //{
        //    DateTime now = DateTime.Today;
        //   // var deptId = Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst("DepartmentId").Value ?? "0");

        //    var cycles = UnitOfWork.RequestsBL.GetUserCycles(cu =>
        //                                                        cu.UserId == LoggedUserId &&
        //                                                        cu.Cycle.IsActive == true &&
        //                                                        cu.Cycle.StartDate <= now &&
        //                                                        cu.Cycle.EndDate >= now &&
        //                                                        cu.Cycle.ReconciliationDate >= now &&
        //                                                        cu.User.DepartmentId == cu.Cycle.DepartmentId
        //                                                    )
        //                                                    .Select(f => new
        //                                                    {
        //                                                        f.Cycle.Name,
        //                                                        f.Cycle.CycleId,

        //                                                    }).ToList();
        //    return Json(cycles);

        //}
        #endregion

        #region NewRequest

        public IActionResult NewRequest()
        {
            return View();
        }
        [HttpPost]
        public JsonResult NewRequest(string cycleId, string userId, List<string> Arr)
        {
            int CId = int.Parse(cycleId.ToString());
            //int UId = int.Parse(userId.ToString());
            List<string> Items = Arr;
            try
            {
                List<RequestDetail> RequesDetalistList = new List<RequestDetail>();

                // create request details
                foreach (var item in Items)
                {
                    var _arr = item.Split(':').Select(Int32.Parse).ToList();
                    int prodid = _arr[0];
                    if (_arr[1] < 1) continue;
                    else
                    {
                        var reqDetalis = new RequestDetail();
                        reqDetalis.ProductId = prodid;
                        reqDetalis.RequestAmount = _arr[1];
                        RequesDetalistList.Add(reqDetalis);
                    }


                }

                // create new request
                var requst = new Request();
                requst.CycleId = CId;
                requst.Status = false;
                requst.CreatedById = LoggedUserId;
                requst.CreateDate = DateTime.Now;
                requst.RequestDetail = RequesDetalistList;

                UnitOfWork.RequestsBL.Add(requst);

                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new { Success = true, Message = ApplicationMessages.SaveSuccess });

                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.SaveFailed });
                }

            }
            catch (Exception e)
            {
                // error
                return Json(new { Success = false, Message = "Exception", Error = e.Message });
            }


        }
        #endregion


        #region RequestSearch --Partial View

        [PermissionNotRequired]
        public PartialViewResult RequestSearch(Request request, DateTime to_Date)
        {
            try
            {
                var model = UnitOfWork.RequestsBL.FilterRequest(request, to_Date)
                                        .Where(f => f.CreatedById == LoggedUserId).OrderByDescending(f => f.CreateDate)
                                        .ToList();

                return PartialView("_PartialRequests", model);
            }
            catch (Exception)
            {
                return PartialView("_PartialRequests", null);

            }
        }
        #endregion

        #region RequestsInbox index

        public IActionResult RequestsInbox()
        {

            return View();
        }
        #endregion

        #region RequestsInboxList 

        [PermissionNotRequired]
        public PartialViewResult RequestsInboxList()
        {

            try
            {
                List<Request> Result = null;
                if (LoggedIsSystemAdmin)
                {
                    Result = UnitOfWork.RequestsBL.GetAllRequests(r => r.Cycle.Department.IsActive ==true).ToList();
                }
                else // normal user 
                {
                    Result = UnitOfWork.RequestsBL.GetAllRequests(r => r.Cycle.DepartmentId == LoggedUserDepartmentId).ToList();
                }
                var model = Result?
                     .Select(f => new RequestsInboxVM
                     {
                         ReqID = f.RequestId,
                         CycleID = f.Cycle.CycleId,
                         CycleName = f.Cycle.Name,
                         CycleType = f.Cycle.Type,

                         ReqStatus = f.Status,
                         ReqByID = f.CreatedById.GetValueOrDefault(),
                         ReqDate = f.CreateDate.GetValueOrDefault(),
                         ReqAmount = f.RequestDetail.Where(c => c.RequestId == f.RequestId)
                                   .Sum(c => c.RequestAmount).GetValueOrDefault(),
                         CreartedByName = f.CreatedBy.JobTitle.Name

                     }).OrderByDescending(r=>r.ReqDate).ToList();
                if (model != null)
                {
                    return PartialView("_RequestsInboxList", model);

                }
                else
                {
                    return PartialView("_RequestsInboxList", null);

                }
            }
            catch (Exception ex)
            {

                return PartialView("_RequestsInboxList", ex);
            }



        }
        #endregion


        #region SearchRequestsInbox --Partial View
        [PermissionNotRequired]
        public PartialViewResult SearchRequestsInbox(Request request, DateTime to_Date)
        {
            try
            {
                var model = UnitOfWork.RequestsBL.FilterRequest(request, to_Date).Select(f => new RequestsInboxVM
                {
                    ReqID = f.RequestId,
                    CycleID = f.Cycle.CycleId,
                    CycleName = f.Cycle.Name,
                    CycleType = f.Cycle.Type,

                    ReqStatus = f.Status,
                    ReqByID = f.CreatedById.GetValueOrDefault(),
                    ReqDate = f.CreateDate.GetValueOrDefault(),
                    ReqAmount = f.RequestDetail.Where(c => c.RequestId == f.RequestId)
                                         .Sum(c => c.RequestAmount).GetValueOrDefault(),
                    CreartedByName = f.CreatedBy.JobTitle.Name

                }
         );
                return PartialView("_RequestsInboxList", model);
            }
            catch (Exception)
            {
                return PartialView("_RequestsInboxList", null);

            }
        }
        #endregion

        #region AcceptRequest
        [HttpPost]
        public JsonResult AcceptRequest(int RequestId, List<string> Arr, int hrUserSelected)
        {
            List<string> Items = Arr;

            var model = UnitOfWork.RequestsBL.GetRequestDetails(f => f.RequestId == RequestId).ToList();
            var BBXUsers = UnitOfWork.CyclesBL
                        .GetUserCyclesUserByJobName(model.FirstOrDefault().Request.CycleId.GetValueOrDefault(), "bbx");
            int bbxuserId = BBXUsers.FirstOrDefault() != null ? BBXUsers.FirstOrDefault().UserId : 0;
            // var allProducts = UnitOfWork.ProductBL.GetAllActiveProductsWithDepartments(null);
            var allProducts = UnitOfWork.ProductBL.GetAll();

            var inventoryLogs = new List<InventoryLog>();
            var notification = new List<Notifications>();

            bool ok = true;

            foreach (var item in Items)
            {
                var _arr = item.Split(':').Select(Int32.Parse).ToList();
                int prodid = _arr[0];
                if (_arr[1] < 1) continue;
                else
                {

                    if (_arr[1] > allProducts.Where(f => f.ProductId == prodid).Select(f => f.InventoryQnty).FirstOrDefault())
                    {
                        ok = false;
                    }

                }

            }

            if (ok == true && bbxuserId > 0)
            {
                // add transaction detalis

                List<TransactionDetail> TranDetList = new List<TransactionDetail>();

                foreach (var item in Items)
                {
                    var _arr = item.Split(':').Select(Int32.Parse).ToList();
                    int prodid = _arr[0];
                    var product = allProducts.FirstOrDefault(p => p.ProductId == prodid);
                    //if (product == null)
                    //{
                    //    continue;
                    //}
                    var availableQuanty = Convert.ToInt32(product.InventoryQnty ?? 0);
                    int prodAmount = _arr[1];
                    if (_arr[1] < 1) continue;
                    else
                    {
                        var tranDetalis = new TransactionDetail();

                        tranDetalis.ProductId = prodid;
                        tranDetalis.TransAmount = prodAmount;
                        TranDetList.Add(tranDetalis);
                        // edit product amount

                        product.Modified = DateTime.Now;
                        product.InventoryQnty = product.InventoryQnty - prodAmount;
                        UnitOfWork.ProductBL.Update(product);
                        var requestDetalis = model.Where(f => f.ProductId == prodid).First();

                        requestDetalis.ApprovedAmount = prodAmount;
                        UnitOfWork.RequestsBL.UpdateRequestDetalis(requestDetalis);


                    }
                    // add inventory
                    inventoryLogs.Add(new InventoryLog
                    {
                        ProductId = prodid,
                        OldQnty = availableQuanty,
                        NewQnty = availableQuanty - prodAmount,
                        Quantity = prodAmount,
                        TransactionType = (int)TransactionTypes.Delivery,
                        UserId = LoggedUserId,
                        CreatedDate = DateTime.Now,
                        ActionType = (int)InventoryActionType.Decrement,
                    });

                }
                // add notification to bbx to confirm

                notification.Add(new Notifications
                {
                    CreatedAt = DateTime.Now,
                    Title = NotificationType.NotConfirmed.ToString(),
                    Notificationtype = (int)NotificationType.NotConfirmed,
                    IsSeen = false,
                    ToUserId = bbxuserId
                });

                // add transaction
                var newtrans = model.Select(f => new Transaction
                {
                    CycleId = f.Request.CycleId,
                    FromUserId = bbxuserId,
                    ToUserId = hrUserSelected,
                    CreateDate = DateTime.Now,
                    TransType = (int)TransactionTypes.Delivery,
                    Status = (int)TransactionStatus.NewRequst,
                    ConfirmDate = DateTime.Now,
                    RequestId = f.RequestId,
                    TransactionDetail = TranDetList,
                    InventoryLog = inventoryLogs,
                    Notifications = notification,

                }).FirstOrDefault();

                UnitOfWork.TransactionBL.Add(newtrans);

                var request = model.Select(f => f.Request).FirstOrDefault();

                request.Status = true;
                request.ModfiedById = LoggedUserId;
                request.ModifiedDate = DateTime.Now;
                UnitOfWork.RequestsBL.Update(request);

                if (UnitOfWork.Complete(LoggedUserId) > 0)
                {
                    return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });

                }
                else
                {
                    return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });
                }

                // update and do transaction
            }
            return Json(new { Success = false, message = "Can't do this request check quantity" });
        }
        #endregion



    }

}


