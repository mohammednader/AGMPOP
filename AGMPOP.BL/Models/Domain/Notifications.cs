﻿using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public long? TransactionId { get; set; }
        public int? ToUserId { get; set; }
        public int? Notificationtype { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? SeenDate { get; set; }
        public bool? IsSeen { get; set; }

        public virtual AppUser ToUser { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
