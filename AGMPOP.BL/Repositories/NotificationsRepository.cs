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
            DateTime now = DateTime.Now;
            var model = Context.Notifications 
                                            .Include(f => f.Transaction)
                                                  .ThenInclude(f => f.Cycle)
                                            .Include(f => f.ToUser)
                                            .Where(nt => nt.ToUserId == LoggedUser && 
                                                                                nt.Transaction.Status != (int)POPEnums.TransactionStatus.Canceled 
                                                                                && nt.Transaction.Cycle.IsActive == true &&
                                                                                nt.Transaction.Cycle.StartDate <= now &&
                                                                                nt.Transaction.Cycle.EndDate >= now && 
                                                                                nt.Transaction.Cycle.Department.IsActive == true
                                            )

                                            .ToList();


            return model;
        }

        public Transaction GetCycleDetalis(int TransID)
        {
            var model = Context.Transaction
                .Where(f => f.TransactionId == TransID)
                .Include(f => f.FromUser).ThenInclude(f => f.JobTitle)
                .Include(f => f.ToUser).ThenInclude(f => f.JobTitle)
                .Include(f => f.TransactionDetail)
                 .FirstOrDefault();
            return model;
        }
        public IEnumerable<TransactionDetail> GetCycleTransDetalis(int TransId)
        {
            var model = Context.TransactionDetail
                  .Include(f => f.Product)
                .Include(f => f.Transaction).ThenInclude(f => f.Cycle).Where(f => f.TransactionId == TransId)
                .ToList();
            return model;
        }
        public int GetCountUnSeenNotification(int LoggedUser)
        {
            var ModelCount = Context.Notifications
                                                  .Where(f => f.ToUserId == LoggedUser)
                                                  .Count(n => n.IsSeen != true);
            return ModelCount;

        }
    }
}
