using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
   public class TerritoryVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Inactive { get; set; }
        public int? ParentId { get; set; }
    }
}
