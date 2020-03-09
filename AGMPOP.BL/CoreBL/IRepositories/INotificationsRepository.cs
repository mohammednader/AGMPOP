using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
  public  interface INotificationsRepository :IGenericRepository<Notifications>
    {
        //custon method

        IEnumerable<Notifications> GetAllDetailsForUser(int LoggedUser);
         Transaction  GetCycleDetalis(int TransID);
        IEnumerable<TransactionDetail> GetCycleTransDetalis(int TransId);
        int GetCountUnSeenNotification(int LoggedUser);
    }
}
