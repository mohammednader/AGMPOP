using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class TransactionDetailsRepository : GenericRepository<TransactionDetail>, ITransactionDetailsRepository
    {
        public TransactionDetailsRepository(AGMPOPContext context) : base(context)
        {


        }

        public List<TransactionDetail> GetAllTransDetails(Expression<Func<TransactionDetail, bool>> predicate)
        {

            var query = Context.TransactionDetail.Include(f => f.Product).AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            return query.ToList();
        }
    }
}
