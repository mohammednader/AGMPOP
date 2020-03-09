using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        IList<TransactionCycle> GetCycleTransactions(int CycleId);
        IList<TransactionCycle> GetAllTransaction();
        IList<Transaction> GetTransactionCycleDetails(TransactionCycle transaction);
        IList<TransactionDetailsAPI> GetAllTransactionAPI(Expression<Func<Transaction, bool>> predicate);
        List<Transaction> GetAllTransactionWithDetails(Expression<Func<Transaction, bool>> predicate);
    }
}
