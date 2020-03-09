using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.Repositories
{
    public class UserClearanceRepository : GenericRepository<UserClearance>, IUserClearanceRepository
    {
        public UserClearanceRepository(AGMPOPContext context) : base(context)
        {
        }

        public void UpdateUserClearance(int userId, int cycleId, int productId, decimal quantity, bool updateTotalAmount = true)
        {
            if (userId != 0 && cycleId != 0 && productId != 0 && quantity != 0)
            {
                var clearance = FindOne(cc => cc.UserId == userId && cc.CycleId == cycleId && cc.ProductId == productId);
                if (clearance != null)
                {
                    //if (quantity > 0)
                    {

                    }
                    // amount negative && dudction more than the current remaining
                    if (-quantity > clearance.ClearanceQuantity)
                    {
                        return; // supposed to throw an exception
                    }
                    if (updateTotalAmount)
                        clearance.TotalQuantity += quantity;

                    clearance.ClearanceQuantity += quantity;
                    Update(clearance);
                }
                else if (quantity < 0)
                {
                    return; // supposed to throw an exception
                }
                else
                {
                    clearance = new UserClearance
                    {
                        UserId = userId,
                        CycleId = cycleId,
                        ProductId = productId,
                        ClearanceQuantity = quantity,
                        TotalQuantity = quantity,
                    };
                    Context.UserClearance.Add(clearance);
                }
            }
        }
        /// <summary>
        ///  overwrite exisitng clearance with the quantities whch have been calculated out of this method 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cycleId"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        /// <param name="newQuantity"></param>
        public void OverwriteUserClearance(int userId, int cycleId, int productId, decimal quantity, decimal newQuantity)
        {
            if (userId != 0 && cycleId != 0 && productId != 0 && quantity != 0)
            {
                var clearance = FindOne(cc => cc.UserId == userId && cc.CycleId == cycleId && cc.ProductId == productId);
                if (clearance != null)
                {
                    clearance.TotalQuantity += newQuantity;
                    clearance.ClearanceQuantity = quantity;
                    Update(clearance);
                }
                else if (quantity < 0)
                {
                    return; // supposed to throw an exception
                }
                else
                {
                    clearance = new UserClearance
                    {
                        UserId = userId,
                        CycleId = cycleId,
                        ProductId = productId,
                        ClearanceQuantity = quantity,
                        TotalQuantity = quantity,
                    };
                    Context.UserClearance.Add(clearance);
                }
            }
        }

        public void TestMethod(string connection)
        {
            var dt = new DataTable();
            using (var client = new SqlConnection(connection))
            {
                client.Open();
                var cmd = "SELECT * FROM [V_CycleProductQuantity]";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd, connection);
                sqlDataAdapter.Fill(dt);
            }
            //var x = Context.VCycleProductQuantity.Where(e => e.UserId == 3).ToList();
            //x.Add(null);
        }

        public List<UserClearance> GetAllWithDetails(Expression<Func<UserClearance, bool>> predicate)
        {
            var query = Context.UserClearance.Include(c => c.Product).AsQueryable();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query.ToList();

        }


    }
}
