using AGMPOP.BL.CoreBL;
using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Helpers;
using AGMPOP.BL.Models.Domain;

namespace AGMPOP.BL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AGMPOPContext _context;

        public IDepartmentRepository DepartmentBL { get; }
        public IProductRepository ProductBL { get; }
        public IJobTitleRepository JobTitleBL { get; }
        public IAppUserRepository AppUserBL { get; }
        public IRoleRepository RoleBL { get; }
        public IPermissionRepository PermissionBL { get; }
        public ITerritoriesRepository TerritoriesBL { get; }
        public ICycleUserRepository CycleUserBL { get; }
        public ICycleProductRepository CycleProductBL { get; }
        public ICyclesRepository CyclesBL { get; set; }
        public ITransactionDetailsRepository TransactionDetailsBL { get; set; }
        public ITransactionRepository TransactionBL { get; set; }
        public IRequestsRepository RequestsBL { get; set; }

        public IInventoryLogRepository InventoryLogBL { get; set; }
        public INotificationsRepository NotificationsBL { get; set; }
        public IUserClearanceRepository UserClearanceBL { get; set; }
        public IAuditRepository AuditBL{ get; set; }

        public UnitOfWork(
            AGMPOPContext context,
            IDepartmentRepository departmentRepository,
            IProductRepository productRepository,
            IJobTitleRepository jobTitleRepository,
            IAppUserRepository appUserRepository,
            IRoleRepository roleRepository,
            IPermissionRepository permissionRepository,
            ITerritoriesRepository territoriesRepository,
            ICycleUserRepository cycleUserRepository,
            ICycleProductRepository cycleProductRepository,
            ICyclesRepository cyclesRepository,
            ITransactionDetailsRepository TransactionDetailsRepository,
            ITransactionRepository TransactionRepository,
            IRequestsRepository requestRepository,
            IInventoryLogRepository inventoryLogRepository,
            INotificationsRepository notificationsRepository,
            IUserClearanceRepository userClearanceRepository,
            IAuditRepository AuditRepository 


            )
        {
            _context = context;
            DepartmentBL = departmentRepository;
            ProductBL = productRepository;
            JobTitleBL = jobTitleRepository;
            AppUserBL = appUserRepository;
            RoleBL = roleRepository;
            PermissionBL = permissionRepository;
            TerritoriesBL = territoriesRepository;
            CycleUserBL = cycleUserRepository;
            CycleProductBL = cycleProductRepository;
            CyclesBL = cyclesRepository;
            TransactionDetailsBL = TransactionDetailsRepository;
            TransactionBL = TransactionRepository;
            RequestsBL = requestRepository;
            InventoryLogBL = inventoryLogRepository;
            NotificationsBL = notificationsRepository;
            UserClearanceBL = userClearanceRepository;
            AuditBL = AuditRepository;

        }

        public int Complete(int loggedUserId)
        {
            var helper = new AuditHelper(_context, loggedUserId);
            var remaining = helper.OnBeforeSaveChanges();
            int result = _context.SaveChanges();
            helper.OnAfterSaveChanges(remaining);
            return result;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
