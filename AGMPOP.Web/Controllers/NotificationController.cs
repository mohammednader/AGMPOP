using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Models.Notifications;
using Microsoft.AspNetCore.Mvc;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Controllers
{
    public class NotificationController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        public NotificationController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }
        //public JsonResult notificationsList()
        //{
        //    //var model = UnitOfWork.NotificationsBL.GetAllDetailsForUser(LoggedUserId).Select(f=> new NotificationVM
        //    var model = UnitOfWork.NotificationsBL.GetAllDetailsForUser(4).Select(f => new NotificationVM
        //    {
        //        Id = f.Id,
        //        TransactionId = f.TransactionId,
        //        CycleId = f.Transaction.CycleId.GetValueOrDefault(),
        //        Title = f.Title,
        //        Message = f.Message,
        //        UserName = f.ToUser.FullName,
        //        Notificationtype = f.Notificationtype,
        //        createdAt = f.CreatedAt.GetValueOrDefault(),
        //        IsSeen = f.IsSeen,
        //        SeenDate = f.SeenDate,
        //    });
        //    return Json(model);
        //}

        public JsonResult GetCycleName(int cycleId)
        {
            //var model = UnitOfWork.NotificationsBL.GetAllDetailsForUser(LoggedUserId).Select(f=> new NotificationVM
            var model = UnitOfWork.CyclesBL.Find(f => f.CycleId == cycleId).Select(f => new CycleVM
            {
                CycleId = f.CycleId,
                Name = f.Name,
                CycleType = f.Type,
                StartDate = f.StartDate,
                EndDate = f.EndDate,
            }).FirstOrDefault();
            return Json(model);
        }


        public JsonResult GetCycleDetalis(int cycleId, int TransID)
        {
            var model = UnitOfWork.NotificationsBL.GetCycleDetalis(TransID);
            var res = new NotificationCycleDetails()
            {
                FromUserName = model.FromUser.JobTitle.Name,
                ToUserName = model.ToUser.JobTitle.Name,
                AllItems = model.TransactionDetail.Sum(f => f.TransAmount),

            };
            return Json(res);
        }

        public JsonResult GetTransactions(int cycleId, int TransID)
        {
            var model = UnitOfWork.NotificationsBL.GetCycleTransDetalis(TransID).Select(f => new TransactionNotifcation
            {
                ProductName = f.Product.Name,
                ProductImg = f.Product.Image,
                Code = f.Product.Code,
                Quantity = f.TransAmount,
                 TypeName = f.Product.TypeId == 1 ? "BBO" : "Product",
            }).ToList();
            return Json(model);
        }

        public JsonResult UpdateNotification(int cycleid, int transid, int notificationid)
        {
            try
            {
                // var userJob = UnitOfWork.AppUserBL.GetUserWithJobTitle(LoggedUserId);
                var userJob = UnitOfWork.AppUserBL.GetUserWithJobTitle(4);
 
                if (userJob.JobTitle.Name.ToLower() == "bbx")
                {
                    var NotifiModel = UnitOfWork.NotificationsBL.Find(f => f.Id == notificationid).FirstOrDefault();
                    NotifiModel.Title = "Approved";
                    NotifiModel.Notificationtype = (int)NotifucationType.Confirmed;
                    UnitOfWork.NotificationsBL.Update(NotifiModel);

                    // make trans pending
                    var TransModel = UnitOfWork.TransactionBL.Find(f => f.TransactionId == transid).FirstOrDefault();
                    TransModel.Status = (int)TransactionStatus.Pending;
                    TransModel.ModifiedDate = DateTime.Now;

                    UnitOfWork.TransactionBL.Update(TransModel);
                     var NewNotif = new Notifications()
                    {
                        TransactionId = transid,
                        ToUserId = TransModel.ToUserId,
                        Notificationtype = (int)NotifucationType.NotConfirmed,
                        Title = (string)TransactionStatus.Pending.ToString(),
                        CreatedAt = DateTime.Now,

                    };
                    UnitOfWork.NotificationsBL.Add(NewNotif);


                    if (UnitOfWork.Complete() > 0)
                    {
                        return Json(new { Success = true, Message = "Confirmed" });
                    }

                }

                if (userJob.JobTitle.Name.ToLower() == "hr")
                {
                    var NotifiModel = UnitOfWork.NotificationsBL.Find(f => f.Id == notificationid).FirstOrDefault();
                    NotifiModel.Title = "Approved";
                    NotifiModel.Notificationtype = (int)NotifucationType.Confirmed;
                    UnitOfWork.NotificationsBL.Update(NotifiModel);

                    var TransModel = UnitOfWork.TransactionBL.Find(f => f.TransactionId == transid).FirstOrDefault();
                    TransModel.Status = (int)TransactionStatus.Confirmed;
                    TransModel.ConfirmDate = DateTime.Now;
                    UnitOfWork.TransactionBL.Update(TransModel);

                    if (UnitOfWork.Complete() > 0)
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

        public JsonResult SeenAt(int notificationId)
        {
            try
            {
                var model = UnitOfWork.NotificationsBL.Find(f => f.Id == notificationId).FirstOrDefault();
                model.SeenDate = DateTime.Now;
                model.IsSeen = true;
                UnitOfWork.NotificationsBL.Update(model);
                if (UnitOfWork.Complete()>0)
                {
                    return Json(new { Success = true, Message = "Seen" });

                }

            }

            catch (Exception)
            {

                return Json(new { Success = false, Message = "There is an error" });

            }
            return Json(new { Success = false, Message = "There is an error" });

        }
    }
}