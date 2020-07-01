using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AGMPOP.Web.Models.Product
{
    public class ProductExport
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string DepartmentName { get; set; }
        // public string Type { get; set; }
        public ProductExport(ProductDTO p)
        {
            Name = p.ProductName;
            Code = p.Code;
            DepartmentName = p.DepartmentName;
        }

    }
}
