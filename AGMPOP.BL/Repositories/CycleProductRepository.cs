using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class CycleProductRepository : GenericRepository<CycleProduct>, ICycleProductRepository
    {
        public CycleProductRepository(AGMPOPContext context) : base(context)
        {

        }


        public List<ProductCycleModel> GetCycleProductWithDetails(int TransactionId)
        {
            return Context.TransactionDetail
                                .Include(c => c.Transaction)
                                .Include(c => c.Product)
                                .Where(c => c.TransactionId == TransactionId)

                                .Select(c => new ProductCycleModel
                                {
                                    ProductName = c.Product.Name,
                                    ProductId = c.ProductId,
                                    Code = c.Product.Code,
                                    ProductImg = c.Product.Image,
                                    Quantity = c.TransAmount,
                                  //  TypeId = c.Product.TypeId.GetValueOrDefault(),
                                })
                                .ToList();

        }

        public List<ProductCycleModel> GetCycleProduct(Expression<Func<CycleProduct, bool>> predicate = null)
        {
            var query = Context.CycleProduct
                               .Include(c => c.Product)
                               .Include(c => c.Cycle).AsQueryable();

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query
                .Select(c => new ProductCycleModel
                {
                    ProductName = c.Product.Name,
                    CycleName = c.Cycle.Name,
                    ProductId = c.ProductId.GetValueOrDefault(),
                    CycleId = c.CycleId.GetValueOrDefault(),
                    Quantity = c.Qunt.GetValueOrDefault(),
                    RemainingQuant = c.RemainQunt.GetValueOrDefault(),
                    ProductImg = c.Product.Image,
                    //TypeId = c.Product.TypeId.GetValueOrDefault(),
                    Code = c.Product.Code,
                    InventoryQuantity = Convert.ToInt32(c.Product.InventoryQnty.GetValueOrDefault())
                }).ToList();

        }


    }
}
