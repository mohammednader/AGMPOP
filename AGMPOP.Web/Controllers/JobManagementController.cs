using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL.IRepositories;
using Microsoft.AspNetCore.Mvc;
using AGMPOP.BL.CoreBL;
using AGMPOP.Web.Auth;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class JobManagementController : BaseController
    {

        private readonly IUnitOfWork UnitOfWork;
        public JobManagementController(IUnitOfWork _unitOfWorkRepository)
        {
            UnitOfWork = _unitOfWorkRepository;
        }

        public IActionResult Index()
        {
            // auth will be checked here 
            var jobList = UnitOfWork.JobTitleBL.GetAll().ToList();
            return View(jobList);

        }

        [HttpPost]
        public JsonResult AddJob(string JobTitle)
        {
            // auth will be checked here 
            try
            {
                if (!string.IsNullOrEmpty(JobTitle))
                {
                    //will be create custom model for jobs
                    var selected_job = UnitOfWork.JobTitleBL.Find(j => j.Name == JobTitle);
                    if (selected_job.Count > 0)
                    {
                        return Json(new { Success = false, Message = "Job title already exist !" });
                    }
                    UnitOfWork.JobTitleBL.Add(new BL.Models.Domain.JobTitle() { Name = JobTitle, Type = 1 });
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { Success = true, Message = ApplicationMessages.SaveSuccess });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.SaveFailed });
                    }
                }
                else return Json(new { Success = false, Message = ApplicationMessages.IncompleteData });
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });
            }
        }

        public ActionResult DeleteJob(int JobId)
        {
            // auth will be checked here 
            try
            {
                if (JobId != 0)
                {
                    var selectedJob = UnitOfWork.JobTitleBL.FindOne(d => d.JobTitleId == JobId);
                    if (selectedJob != null)
                    {
                        var UserJob = UnitOfWork.AppUserBL.UserAssignToJobTitle(JobId);
                        if (UserJob == true)
                        {
                            return Json(new { Success = false, Message = "you can't delete this job title" });
                        }
                    }
                    UnitOfWork.JobTitleBL.Remove(selectedJob);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { Success = true, Message = ApplicationMessages.DeleteSuccess });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.DeleteFailed });
                    }
                }
                else return Json(new { Success = false, Message = ApplicationMessages.IncompleteData });
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });

            }
        }


        public JsonResult EditJob(string Id, string JobTitle)
        {
            // auth will be checked here 
            try
            {
                if (!string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(JobTitle))
                {
                    int id = 0;

                    int.TryParse(Id, out id);

                    var exist = UnitOfWork.JobTitleBL.CheckExist(j => j.Name == JobTitle && j.JobTitleId != id);
                    if (exist)
                    {
                        return Json(new { Success = false, Message = "Job title already exist !" });
                    }
                    var job = UnitOfWork.JobTitleBL.GetByID(id);
                    job.Name = JobTitle;
                    UnitOfWork.JobTitleBL.Update(job);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        return Json(new { Success = true, Message = ApplicationMessages.UpdateSuccess });
                    }
                    else
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.UpdateFailed });
                    }
                }
                else return Json(new { Success = false, Message = ApplicationMessages.IncompleteData });
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Message = ApplicationMessages.ErrorOccure, Error = e.Message });

            }
        }

        public PartialViewResult _JobTitleList()
        {
            var JobTitleList = UnitOfWork.JobTitleBL.GetAll().ToList();
            return PartialView(JobTitleList);
        }
    }
}
