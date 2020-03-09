using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.Web.Auth;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class DepartmentController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;
        public DepartmentController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }
        public IActionResult Index()
        {
            return View();

        }

        [HttpPost]
        public JsonResult AddDept(string dept)
        {
            // auth will be checked here 
            try
            {
                if (!string.IsNullOrEmpty(dept))
                {
                    //will be create custom model for department
                    var exist = UnitOfWork.DepartmentBL.Find(d => d.Name == dept);
                    if (exist.Count > 0)
                    {
                        return Json(new { Success = false, Message = ApplicationMessages.AlreadyExist });
                    }

                    UnitOfWork.DepartmentBL.Add(new BL.Models.Domain.Department() { Name = dept, IsActive = true });
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
        [HttpPut]
        public JsonResult ActivateDept(int id)
        {
            // auth will be checked here 
            try
            {
                if (id != 0)
                {
                    var selectedDept = UnitOfWork.DepartmentBL.FindOne(d => d.Id == id);

                    if (selectedDept.IsActive == false || selectedDept.IsActive == null)
                    {
                        selectedDept.IsActive = true;
                    }
                    UnitOfWork.DepartmentBL.Update(selectedDept);

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
                // error 
            }
        }
        [HttpPut]
        public JsonResult DeactivateDept(int id)
        {
            // auth will be checked here 
            try
            {
                if (id != 0)
                {
                    var selectedDept = UnitOfWork.DepartmentBL.FindOne(d => d.Id == id);

                    if (selectedDept.IsActive == true)
                    {
                        selectedDept.IsActive = false;
                    }
                    UnitOfWork.DepartmentBL.Update(selectedDept);

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
                // error 
            }
        }

        public JsonResult EditDept(string Id, string dept)
        {
            // auth will be checked here 
            try
            {
                if (!string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(dept))
                {
                    int id = 0;

                    int.TryParse(Id, out id);
                    var exist = UnitOfWork.DepartmentBL.CheckExist(d => d.Name == dept && d.Id != id);
                    if (exist)
                    {
                        return Json(new { Success = false, Message = "Department already exist !" });
                    }
                    var currentDept = UnitOfWork.DepartmentBL.GetByID(id);
                    currentDept.Name = dept;
                    UnitOfWork.DepartmentBL.Update(currentDept);
                    if (UnitOfWork.Complete(LoggedUserId) > 0)
                    {
                        // success 
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

        public ActionResult _departmentList()
        {
            var DepartmentList = UnitOfWork.DepartmentBL.GetAll().ToList();
            return PartialView(DepartmentList);
        }
    }
}