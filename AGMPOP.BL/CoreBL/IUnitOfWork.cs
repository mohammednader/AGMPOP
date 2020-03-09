using AGMPOP.BL.CoreBL.IRepositories;

using System;


namespace AGMPOP.BL.CoreBL
{
    public interface IUnitOfWork : IDisposable
    {

        //Define Interfaces
        IDepartmentRepository DepartmentBL { get; }
        IProductRepository ProductBL { get; }
        IJobTitleRepository JobTitleBL { get; }
        IAppUserRepository AppUserBL { get; }
        IRoleRepository RoleBL { get; }
        IPermissionRepository PermissionBL { get; }
        ITerritoriesRepository TerritoriesBL { get; }
        ICycleUserRepository CycleUserBL { get; }
        ICycleProductRepository CycleProductBL { get; }
        ICyclesRepository CyclesBL { get; }
        ITransactionDetailsRepository TransactionDetailsBL { get; }
        ITransactionRepository TransactionBL { get; }
        IRequestsRepository RequestsBL { get; }
        IInventoryLogRepository  InventoryLogBL { get; }
        INotificationsRepository NotificationsBL { get; }
        IUserClearanceRepository UserClearanceBL { get; }
        IAuditRepository IAuditBL { get; }
        int Complete(int userId);
    }
}
