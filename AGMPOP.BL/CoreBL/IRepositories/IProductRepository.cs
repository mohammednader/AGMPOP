using AGMPOP.BL.Models.Domain;
using System.Collections.Generic;
using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.ViewModels;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        // GetAllProducts by earch
        List<Product> FilterProducts(ProductDTO product);
        List<Product> GetAllProductList();
        ProductDTO GetProductWithDepartmentByid(int id);


        List<object> ProductTypeList();

        List<Product> GetAllActiveProductsWithDepartments(int? department = null);
        List<CycleProduct> GetproductInCycle(int? cycleid = null);


    }
}
