using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGMPOP.BL.Repositories
{
   public class NotificationsRepository : GenericRepository<Notifications>, INotificationsRepository
    {
        public NotificationsRepository(AGMPOPContext context) : base(context)
        {

        }

        public IEnumerable<Notifications> GetAllDetailsForUser(int LoggedUser)
        {

            var model = Context.Notifications
                .Where(f=>f.ToUserId==LoggedUser)
                .Include(f=>f.Transaction)
                .ThenInclude(f=>f.Cycle)
               .Include(f=>f.ToUser)
                .ToList();
            return  model.Where(f=>f.Transaction.TransType != (int)POPEnums.TransactionStatus.Canceled);
         }

        public Transaction GetCycleDetalis(int TransID)
        {
            var model = Context.Transaction
                .Where(f => f.TransactionId == TransID)
                .Include(f=>f.FromUser).ThenInclude(f => f.JobTitle)
                .Include(f=>f.ToUser).ThenInclude(f=>f.JobTitle)
                .Include(f => f.TransactionDetail)
                 .FirstOrDefault();
            return model;
         }
        public IEnumerable<TransactionDetail> GetCycleTransDetalis(int TransId)
        {
            var model = Context.TransactionDetail
                  .Include(f => f.Product)
                .Include(f => f.Transaction).ThenInclude(f=>f.Cycle).Where(f=>f.TransactionId == TransId)
                .ToList();
            return model;
         }
        public int GetCountUnSeenNotification(int LoggedUser)
        {
            var ModelCount = Context.Notifications
                                                  .Where(f => f.ToUserId == LoggedUser)
                                                  .Count(n=>n.IsSeen ==false);
            return ModelCount;

        }
   }
}
