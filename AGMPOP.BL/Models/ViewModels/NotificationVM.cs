using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class NotificationVM
    {
        public int Id { get; set; }
        public long? TransactionId { get; set; }
        public int? ToUserId { get; set; }
        public string UserName { get; set; }
        public int? Notificationtype { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int? CycleId  { get; set; }
        public string CycleName { get; set; }
      //  public DateTime? CreatedAt { get; set; }
        public DateTime? SeenDate { get; set; }
        public bool? IsSeen { get; set; }
        public DateTime createdAt { get; set; }
    }
}
