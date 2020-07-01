using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using AGMPOP.Web.Auth;
using Microsoft.AspNetCore.Mvc;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class CommonController : BaseController
    {
        private readonly IUnitOfWork UnitOfWork;

        //[AppAuthorize]
        public CommonController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        [PermissionNotRequired]
        public JsonResult GetAllRoles()
        {
            var roles = UnitOfWork.RoleBL.GetAll();
            var response = roles.Select(r => new { r.Id, r.Name }).ToArray();
            return Json(response);
        }

        [PermissionNotRequired]
        public JsonResult GetAllJobTitles()
        {
            var jobtitles = UnitOfWork.JobTitleBL.GetAll();
           // var jobtitles = UnitOfWork.JobTitleBL.GetAll().Where(j => j.Name.ToLower() != "admin");
            var response = jobtitles.Select(j => new { Id = j.JobTitleId, j.Name });
            return Json(response);
        }

        [PermissionNotRequired]
        public JsonResult GetAllDepartments()
        {

            List<Department> departments = null;
            if (LoggedIsSystemAdmin)
            {
                departments = UnitOfWork.DepartmentBL.Find(d => d.IsActive == true);
            }
            else
            {
                departments = UnitOfWork.DepartmentBL.Find(d => d.Id == LoggedUserDepartmentId).ToList();
            }
            var response = departments?.Select(d => new { d.Id, d.Name });
            return Json(response);
        }

        [PermissionNotRequired]
        public JsonResult GetAllProductTypes()
        {
            var types = Enum.GetValues(typeof(ProductType))
                            .Cast<ProductType>()
                            .Select(item => new
                            {
                                Id = (int)item,
                                Name = item.ToString(),
                            }).ToArray();

            return Json(types);
        }

        [PermissionNotRequired]
        public JsonResult RequestUserCycle()
        {
            DateTime now = DateTime.Now;

            var cycles = UnitOfWork.RequestsBL.GetUserCycles(cu =>
                                                                cu.Cycle.IsActive == true &&
                                                                cu.Cycle.StartDate <= now &&
                                                                cu.Cycle.EndDate >= now &&
                                                               // cu.Cycle.ReconciliationDate >= now &&
                                                                cu.Cycle.Department.IsActive == true &&
                                                                (LoggedIsSystemAdmin || (cu.UserId == LoggedUserId))
                                                            )
                                                            .Select(f => new
                                                            {
                                                                f.Cycle.Name,
                                                                f.Cycle.CycleId,

                                                            }).ToList();
            return Json(cycles);

        }
        [PermissionNotRequired]
        public JsonResult CurrentUserCycles()
        {
            DateTime now = DateTime.Now;
            var cycles = UnitOfWork.CyclesBL.Find(c => 
                                                               c.IsActive == true &&
                                                               c.StartDate <= now &&
                                                               c.EndDate >= now &&
                                                               c.ReconciliationDate >= now &&
                                                               c.Department.IsActive == true
                                                               && (LoggedIsSystemAdmin || (c.DepartmentId == LoggedUserDepartmentId))

                                                               ).Select(c => new
                                                               {
                                                                   c.Name,
                                                                   Id = c.CycleId
                                                               });

            return Json(cycles);

        }
        [PermissionNotRequired]
        public JsonResult GetAllAuditAction()
        {
            var Action = Enum.GetValues(typeof(AuditActionType))
                            .Cast<AuditActionType>()
                            .Select(item => new
                            {
                                Id = (int)item,
                                Name = item.ToString(),
                            }).ToArray();

            return Json(Action);
        }

    }
}