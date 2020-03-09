using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class TranactionDetailsDto
    {
        public string Name { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        public int Quantity { get; set; }
        public int ActionType { get; set; }
        public string CreatedDate { get; set; }
        public string Image { get; set; }
    }
}
