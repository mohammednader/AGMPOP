using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.Web.Models.Audit
{
    public class AuditExport
    {
        public string UserName { get; set; }
        public DateTime? Date { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }

        public AuditExport(DataAudit obj)
        {
            UserName = obj.User?.FullName;
            Date = obj.Date;
            Action = Enum.GetName(typeof(AuditActionType), obj.ActionTypeId).ToString();
            TableName = obj.TableName;
            OldData = obj.OldData;
            NewData = obj.NewData;
        }
        
    }
}
