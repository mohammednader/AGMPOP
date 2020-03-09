using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AGMPOP.BL.CoreBL;
using AGMPOP.Web.Models;
using AGMPOP.Web.Auth;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AGMPOP.Web.Controllers
{
    [AppAuthorize]
    public class HomeController : BaseController
    {
        private IUnitOfWork UnitOfWork;

        public HomeController(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }

        [PermissionNotRequired]
        public IActionResult Index()
        {
            ViewBag.Name = LoggedUserFullName;
            return View();
        }

        [Route("Unauthorized")]
        [AllowAnonymous]
        public IActionResult AppUnauthorized()
        {
            return View("Unauthorized");
        }

        [AppAuthorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


     


    }
}
