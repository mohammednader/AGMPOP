using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class JobTitleRepository :GenericRepository<JobTitle> ,IJobTitleRepository
    {
       
        public JobTitleRepository(AGMPOPContext context):base(context)
        {
            
        }
    }
}
