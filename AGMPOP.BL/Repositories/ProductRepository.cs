using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.BL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AGMPOPContext Context) : base(Context)
        {

        }



        public List<Product> FilterProducts(ProductDTO product)
        {
            //var query = Context.Product

            //                           .Where(p => product.TypeId == null || p.TypeId == product.TypeId)
            //                           .Where(p => string.IsNullOrEmpty(product.Name) || p.Name.Contains(product.Name))
            //                           .Where(p => product.DepartmentId == null || p.DepartmentId == product.DepartmentId)
            //                           .Include(c => c.Department);


            //return query;

            var query = Context.Product
                                        .Include(p => p.Department)
                                        .Where(p=>p.Department.IsActive == true)
                                        .AsQueryable();
            if (product.IsInventory==true)
            {
                query = query.Where(p => p.IsActive == true);
            }
            //if (product.Types?.Count > 0)
            //{
            //    query = query.Where(p => product.Types.Contains(p.TypeId));

            //}
            if (product.DepartmentIds?.Count > 0)
            {
                query = query.Where(p => product.DepartmentIds.Contains(p.DepartmentId));
            }

            if (!string.IsNullOrEmpty(product.ProductName))
            {
                query = query.Where(p => p.Name.Contains(product.ProductName));
            }
            if (product.UserDepartmentId > 0)
            {
                query = query.Where(p => p.DepartmentId == product.UserDepartmentId);
            }



            return query.ToList();


        }



        public List<Product> GetAllProductList()
        {

            return Context.Product.Include(f => f.Department).ToList();
        }

        public ProductDTO GetProductWithDepartmentByid(int id)
        {


            var data = Context.Product.Where(f => f.ProductId == id).Include(f => f.Department).Select(c => new ProductDTO
            {
                ProductId = c.ProductId,
                Name = c.Name,
                //TypeId = c.TypeId.GetValueOrDefault(),
                Code = c.Code,
                CreatedBy = c.CreatedBy,
                StringCreatedDate = c.CreatedDate.ToString(),
                Image = c.Image,
                InventoryQnty = c.InventoryQnty,
                DepartmentID = c.DepartmentId ?? 0,
                DepartmentName = c.Department.Name.ToString()

            }).FirstOrDefault();
            return data;

        }

        public List<object> ProductTypeList()
        {
            var result = new List<object>();
            Enum.GetValues(typeof(ProductType))
                    .Cast<ProductType>()
                    .ToList()
                    .ForEach(e =>
                    {
                        result.Add(new { TypeId = (int)e, Name = e.ToString() });
                    });

            return result;
        }

        public List<Product> GetAllActiveProductsWithDepartments(int? department = null)
        {
            var result = new List<Product>();
            try
            {

                result = Context.Product
                                .Where(p => p.IsActive == true && (department == null || p.DepartmentId == department))
                                .OrderBy(p => p.Name)
                                .Include(p => p.Department)
                                .ToList();
            }
            catch { }
            return result;
        }

        public List<CycleProduct> GetproductInCycle(int? cycleid = null)
        {

            return Context.CycleProduct.Where(f => f.CycleId == cycleid).Include(f=>f.Cycle).Include(p=>p.Product)
                .ToList();
         }
    }
}
