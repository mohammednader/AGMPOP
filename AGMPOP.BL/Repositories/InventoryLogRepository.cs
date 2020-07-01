using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AGMPOP.BL.Repositories
{
   public class InventoryLogRepository :GenericRepository<InventoryLog>,IInventoryLogRepository 
    {
        public InventoryLogRepository (AGMPOPContext context):base(context)
        {

        }

        public List<InventoryLog> GetIventoryLogTrans(int productId)
        {
            var model = Context.InventoryLog.Where(f=>f.ProductId == productId)
                                .Include(f => f.Product)
                                .Include(f => f.Transaction).ThenInclude(f => f.Cycle)
                                .OrderByDescending(d=>d.CreatedDate)                                
                                .ToList();
            return model;
 
        }

        public List<Product> GetProductsWithTransaction(int productId)
        {
            var data = Context.Product.Where(p => p.ProductId == productId)
                            .Include(p => p.InventoryLog)
                            .Include(p => p.TransactionDetail)
                            .Include(p=>p.CycleProduct)
                            .ToList();
                   

            return data;
                           
        }


       

    }
}
