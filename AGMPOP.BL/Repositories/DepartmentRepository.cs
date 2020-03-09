
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Repositories;
using AGMPOP.BL.CoreBL.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AGMPOP.BL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    { 
        public DepartmentRepository(AGMPOPContext Context) : base(Context)
        {

        }

      
        //Implement Custom Methods



    }
}
