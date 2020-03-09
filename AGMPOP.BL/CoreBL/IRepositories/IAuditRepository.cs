using System;
using System.Collections.Generic;
using System.Text;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;

namespace AGMPOP.BL.CoreBL.IRepositories
{
   public interface IAuditRepository : IGenericRepository<DataAudit>
    {
        List<DataAudit> AuditSearch(AuditSearchVM search);
    }
}
