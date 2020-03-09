using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ITransactionDetailsRepository:IGenericRepository<TransactionDetail>
    {

        List<TransactionDetail> GetAllTransDetails(Expression<Func<TransactionDetail, bool>> predicate);
    }
}
