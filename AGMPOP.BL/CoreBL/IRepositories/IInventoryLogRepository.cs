using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IInventoryLogRepository :IGenericRepository<InventoryLog>
    {
        List<Product> GetProductsWithTransaction(int productId);
        List<InventoryLog> GetIventoryLogTrans(int productId);
    }
}
