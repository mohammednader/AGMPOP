using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class ProductDTO
    {
        public int? typeId;

        public int ProductId { get; set; }

        public string Name { get; set; }
    //    public int TypeId { get; set; }
        public int DepartmentID { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public decimal? InventoryQnty { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string StringCreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string DepartmentName { get; set; }
        public string departmentname { get; internal set; }
        [Display(Name = "Product Name")]

        public string ProductName { get; set; }
        //public List<int> Department { get; set; }
      //  public List<int?> Types { get; set; }
        public bool IsActive { get; set; }
        public Department Department { get; set; }
        public List<int?> DepartmentIds { get; set; }
        public bool ShowUpdateBtns { get; set; }
        public int? UserDepartmentId { get; set; }
        public bool IsInventory { get; set; }

    }
}
