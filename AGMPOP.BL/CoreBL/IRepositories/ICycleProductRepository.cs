using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface ICycleProductRepository:IGenericRepository<CycleProduct>
    {
        List<ProductCycleModel> GetCycleProductWithDetails(int TransactionId);
        List<ProductCycleModel> GetCycleProduct(Expression<Func<CycleProduct, bool>> predicate = null);
    }
}
