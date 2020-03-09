using AGMPOP.BL.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AGMPOP.BL.CoreBL.IRepositories
{
    public interface IUserClearanceRepository : IGenericRepository<UserClearance>
    {
        /// <summary>
        /// ADD NEGATIVE QUANTITY FOR DEDUCTION
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cycleId"></param>
        /// <param name="productId"></param>
        /// <param name="quantity"></param>
        void UpdateUserClearance(int userId, int cycleId, int productId, decimal quantity, bool updateTotalAmount = true);

        void TestMethod(string connection);
        List<UserClearance> GetAllWithDetails(Expression<Func<UserClearance, bool>> predicate);
        void OverwriteUserClearance(int userId, int cycleId, int productId, decimal quantity, decimal newQuantity);
    }
}
