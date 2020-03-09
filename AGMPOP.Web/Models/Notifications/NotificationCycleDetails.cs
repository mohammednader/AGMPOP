using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Notifications
{
    public class NotificationCycleDetails
    {
        public string FromUserName { get; set; }

        public string ToUserName { get; set; }

        public int Type { get; set; }
        public int AllItems { get; set; }

    }
}
