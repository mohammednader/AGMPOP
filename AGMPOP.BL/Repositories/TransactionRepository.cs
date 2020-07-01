using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(AGMPOPContext context) : base(context)
        {

        }

        public IList<TransactionCycle> GetCycleTransactions(int CycleId)
        {
            var CycleTransaction = Context.Transaction
                                              .Where(c=>c.CycleId== CycleId)
                                              .Include(c => c.TransactionDetail)
                                              .Include(c => c.Cycle)
                                              .Include(c => c.FromUser)
                                              .Include(c => c.ToUser)

                                              .Select(c => new TransactionCycle
                                              {
                                                  FromUserName = c.FromUser.FullName,
                                                  Date = c.CreateDate.ToString(),
                                                  Status = c.Status.GetValueOrDefault(),
                                                  Type = c.TransType.GetValueOrDefault(),
                                                  ToUserName = c.ToUser.FullName,
                                                  TotalItem = c.TransactionDetail.ToList(),
                                                  TransId = c.TransactionId
                                              }).ToList();
            return CycleTransaction;
        }

        public IList<TransactionCycle> GetAllTransaction()
        {
      //  var AllUsers=  .Where(u => u.Id == c.CreatedById) .Select(u => u.FullName).FirstOrDefault()
            var transactions = Context.Transaction
                                              .Include(c => c.TransactionDetail)
                                              .Include(c => c.Cycle)
                                              .Include(c => c.FromUser)
                                              .Include(c => c.ToUser)
                                              .Select(c => new TransactionCycle
                                              {
                                                  CycleId = c.Cycle.CycleId,
                                                  FromUserName = c.FromUser.FullName,
                                                  Date = c.CreateDate.ToString(),
                                                  Status = c.Status.GetValueOrDefault(),
                                                  Type = c.TransType.GetValueOrDefault(),
                                                  ToUserName = c.ToUser.FullName,
                                                  TotalItem = c.TransactionDetail.ToList(),
                                                  TransId = c.TransactionId,
                                                  CycleName = c.Cycle.Name,
                                                  CreatedBy = "ddd"
                                                //  Context.AppUser.Where(f=>f.Id == c.CreatedById).Select(f=>f.FullName).FirstOrDefault()
                                              }).ToList();
            return transactions;

        }

        public IList<Transaction> GetTransactionCycleDetails(TransactionCycle transaction)
        {
            var query = Context.Transaction
                                        .Include(p => p.Cycle)
                                        .Include(c => c.TransactionDetail).ThenInclude(c => c.Product)
                                        .Include(c => c.FromUser)
                                        .Include(c => c.ToUser)

                                        .AsQueryable();
            if (transaction.types?.Count > 0)
            {
                query = query.Where(p => transaction.types.Contains(p.TransType.Value));

            }
            if (transaction.status?.Count > 0)
            {
                query = query.Where(p => transaction.status.Contains(p.Status.Value));
            }

            if (!string.IsNullOrEmpty(transaction.CycleName))
            {
                query = query.Where(p => p.Cycle.Name.Contains(transaction.CycleName));
            }

            if (!string.IsNullOrEmpty(transaction.FromUserName))
            {
                query = query.Where(p => p.FromUser.FullName.Contains(transaction.FromUserName) || p.ToUser.FullName.Contains(transaction.FromUserName));
            }
            if (transaction.userId > 0)
            {
                query = query.Where(p => p.FromUserId == transaction.userId || p.ToUserId == transaction.userId);
            }
            if (!string.IsNullOrEmpty(transaction.Product))
            {
                query = query.Where(p => p.TransactionDetail.Any(x => x.Product.Name.Contains(transaction.Product)));
            }
            if (transaction.CycleId != 0)
            {
                query = query.Where(p => p.CycleId == transaction.CycleId);
            }

            return query.ToList();
        }

        public IList<TransactionDetailsAPI> GetAllTransactionAPI(Expression<Func<Transaction, bool>> predicate)
        {
            var result2 = new List<TransactionDetailsAPI>();
            try
            {
                var transactions = Context.Transaction
                                                  .Include(c => c.TransactionDetail)
                                                  .Include(c => c.Cycle)
                                                  .Include(c => c.FromUser)
                                                  .Include(c => c.ToUser).AsQueryable();
                if (predicate != null)
                {
                    transactions = transactions.Where(predicate);
                }
                var result = transactions.Select(c => new TransactionDetailsAPI
                {
                    CycleId = c.Cycle.CycleId,
                    FromUserName = c.FromUser.FullName,
                    Date = c.CreateDate,
                    Status = c.Status.GetValueOrDefault(),
                    Type = c.TransType.GetValueOrDefault(),
                    ToUserName = c.ToUser.FullName,
                    TotalItem = c.TransactionDetail.Count(),
                    TypeName = Enum.GetName(typeof(POPEnums.TransactionTypes), c.TransType.GetValueOrDefault()),
                    statusName = Enum.GetName(typeof(POPEnums.TransactionStatus), c.Status.GetValueOrDefault()).Replace("_", " "),
                    TransactionId = int.Parse(c.TransactionId.ToString()),
                    CycleName = c.Cycle.Name,
                    JobTitleId = c.FromUser.JobTitleId == 1 ? "BBX" : "Hr",
                })
                .OrderByDescending(t=>t.Date)
                .ToList();

                return result;

            }
            catch (Exception e)
            {
                return result2;
            }

        }


        public List<Transaction> GetAllTransactionWithDetails(Expression<Func<Transaction, bool>> predicate)
        {
            var Query = Context.Transaction
                                              .Include(c => c.TransactionDetail)
                                              .Include(c=>c.ToUser).ThenInclude(c=>c.JobTitle)
                                               .Include(c => c.FromUser).ThenInclude(c => c.JobTitle)
                                              .AsQueryable();
            if (predicate != null)
            {
                Query = Query.Where(predicate);
            }

            return Query.ToList();

        }

    }
}
