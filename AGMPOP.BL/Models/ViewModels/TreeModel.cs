using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
   public class TreeModel
    {
        public string id { get; set; }

        public string parent { get; set; }

        public string text { get; set; }

        public string icon { get; set; }

        public TreeNodeStatus state { get; set; }
    }



    public class TreeNodeStatus
    {
        public bool opened { get; set; }

        public bool selected { get; set; }

        public bool disabled { get; set; }
    }
}
