using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models
{
    public class ProductVM
    {
        public int ProductId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Name is required")]

        public string Name { get; set; }
       // [Required(AllowEmptyStrings = false, ErrorMessage = "Choose Type")]

      //  public int TypeId { get; set; }

       // public List<int?> Types { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Choose Department")]

        public int DepartmentID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Code is required")]
        public string Code { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Upload Image")]
        public string Image { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Inventory Quantity")]
        public decimal? InventoryQnty { get; set; }
        public DateTime? CreatedDate { get; set; }
         public int? CreatedBy { get; set; }
        public string DepartmentName { get; set; }



    }
 
}
