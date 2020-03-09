using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Auth
{
    /// <summary>
    /// User must login to access this action (without having specific permission)
    /// </summary>
    public class PermissionNotRequiredAttribute : Attribute
    {
    }
}
