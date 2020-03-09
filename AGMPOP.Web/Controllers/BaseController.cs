using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AGMPOP.Web.Controllers
{
    public class BaseController : Controller
    {
        protected int LoggedUserId
        {
            get
            {
                try
                {
                    return Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst("UserId").Value ?? "0");
                }
                catch
                {
                    return 0;
                }
            }
        }

        protected int LoggedUserDepartmentId
        {
            get
            {
                try
                {
                    return Convert.ToInt32(((ClaimsIdentity)User.Identity)?.FindFirst("DepartmentId").Value ?? "0");
                }
                catch
                {
                    return 0;
                }
            }
        }

        protected bool LoggedIsSystemAdmin
        {
            get
            {
                try
                {
                  
                    return Convert.ToBoolean(((ClaimsIdentity)User.Identity)?.FindFirst("IsSysAdmin").Value ?? "false");
                }
                catch
                {
                    return false;
                }
            }
        }

        protected string LoggedUserEmail
        {
            get
            {
                try
                {
                    return ((ClaimsIdentity)User.Identity)?.FindFirst("Email")?.Value;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        protected string LoggedUserFullName
        {
            get
            {
                try
                {
                    return ((ClaimsIdentity)User.Identity)?.FindFirst("Name")?.Value;

                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}