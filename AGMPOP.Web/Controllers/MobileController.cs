using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AGMPOP.Web.Controllers
{
    public class MobileController : BaseController
    {
        #region  abdelarahamn 

        public IActionResult MobileIndex()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var userId = identity.FindFirst("UserId");
            return View();
            if (userId == null)
            {

                return RedirectToAction("loginPage");
            }
            else
            {
                var id = userId.Value;
                if (id == null)
                {
                    return RedirectToAction("loginPage");
                }
                else
                {
                    return View();
                }
            }
        }
        public async Task<IActionResult> loginPage()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme
            );
            return View();
        }


        [HttpGet]
        public IActionResult Clearance()
        {
            return PartialView("_Clearance");
        }


        [HttpPost]
        public async Task<JsonResult> Login(int userId, string email)
        {
            var identity = new ClaimsIdentity(new List<Claim>
            {
                new Claim("Email", email),
                new Claim("UserId", userId.ToString()),
            });
            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
            return Json(true);
        }
        public async Task<JsonResult> LogOut()
        {

            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme
            );
            return Json(true);
        }

        public IActionResult CycleName()
        {
            return View();
        }
        public IActionResult NewDeliveryConfirmation()
        {
            return View();
        }
        public IActionResult AvailableStocks()
        {
            return View();
        }
        public IActionResult NewDeliveryConfirmationBBX()
        {
            return View();
        }
        public IActionResult NewDeliveryConfirmationBBX2step()
        {
            return View();
        }
        public IActionResult NewDeliveryConfirmation2Step()
        {
            return View();
        }
        public IActionResult NewDeliveryConfirmation3Step()
        {
            return View();
        }

        public IActionResult NewDelivery()
        {
            return View();
        }

        public IActionResult NotificationDetails()
        {
            return View("NotificationDetails");
        }
        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
        public IActionResult ChangePassword()
        {
            return View();
        }


        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}


        #endregion
    }
}