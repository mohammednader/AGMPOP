using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AGMPOP.BL.Models.Domain
{
    public partial class AGMPOPContext : DbContext
    {
        
        public AGMPOPContext(DbContextOptions<AGMPOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<CycleProduct> CycleProduct { get; set; }
        public virtual DbSet<CycleTerritory> CycleTerritory { get; set; }
        public virtual DbSet<CycleUser> CycleUser { get; set; }
        public virtual DbSet<Cycles> Cycles { get; set; }
        public virtual DbSet<DataAudit> DataAudit { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<InventoryLog> InventoryLog { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<LnkRolePermission> LnkRolePermission { get; set; }
        public virtual DbSet<LnkUserRole> LnkUserRole { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestDetail> RequestDetail { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Territories> Territories { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetail { get; set; }
        public virtual DbSet<UserClearance> UserClearance { get; set; }
        public virtual DbSet<UserTerritory> UserTerritory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=AGMPOP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.LastModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordHash).HasMaxLength(256);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_User_Department");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_User_JobTitle");
            });

            modelBuilder.Entity<CycleProduct>(entity =>
            {
                entity.ToTable("Cycle_Product");

                entity.HasOne(d => d.Cycle)
                    .WithMany(p => p.CycleProduct)
                    .HasForeignKey(d => d.CycleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Cycle_Product_dbo.Cycles_CycleId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CycleProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Cycle_Product_dbo.Product_ProductId");
            });

            modelBuilder.Entity<CycleTerritory>(entity =>
            {
                entity.ToTable("Cycle_Territory");

                entity.HasOne(d => d.Cycle)
                    .WithMany(p => p.CycleTerritory)
                    .HasForeignKey(d => d.CycleId)
                    .HasConstraintName("FK_Cycle_Territory_CycleId");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.CycleTerritory)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_Cycle_Territory_TerritoryId");
            });

            modelBuilder.Entity<CycleUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CycleId })
                    .HasName("PK_dbo.Cycle_User");

                entity.ToTable("Cycle_User");

                entity.HasOne(d => d.Cycle)
                    .WithMany(p => p.CycleUser)
                    .HasForeignKey(d => d.CycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Cycle_User_dbo.Cycles_CycleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CycleUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Cycle_User_dbo.USERS_UserId");
            });

            modelBuilder.Entity<Cycles>(entity =>
            {
                entity.HasKey(e => e.CycleId)
                    .HasName("PK_dbo.Cycles");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ReconciliationDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Cycles)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Cycle_Department");
            });

            modelBuilder.Entity<DataAudit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionTypeID");

                entity.Property(e => e.AuditId).HasColumnName("AuditID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ObjectKey).HasMaxLength(100);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DataAudit)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DataAudit_UserId");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<InventoryLog>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NewQnty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OldQnty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InventoryLog)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_InventoryLog_Product");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.InventoryLog)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_InventoryLog_transaction");
            });

            modelBuilder.Entity<LnkRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.PermissionId });

                entity.ToTable("LNK_RolePermission");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.LnkRolePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LNK_RolePermission_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LnkRolePermission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LNK_RolePermission_Role");
            });

            modelBuilder.Entity<LnkUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("LNK_UserRole");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.LnkUserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LNK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LnkUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LNK_UserRole_User");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Notificationtype).HasColumnName("notificationtype");

                entity.Property(e => e.SeenDate).HasColumnType("datetime");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK_dbo.Notifications_dbo.AppUser_ToUserId");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Notifications_dbo.Transaction_TransactionId");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PermissionUrl).HasColumnName("PermissionURL");

                entity.Property(e => e.StyleClass).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.InventoryQnty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Product_Department");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedById).HasColumnName("ModifiedBy_Id");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.CreatedById)
                    .HasConstraintName("FK_Request_CreatedById");

                entity.HasOne(d => d.Cycle)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.CycleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Request_dbo.Cycles_CycleId");
            });

            modelBuilder.Entity<RequestDetail>(entity =>
            {
                entity.ToTable("Request_Detail");

                entity.Property(e => e.ApprovedAmount).HasColumnName("Approved_Amount");

                entity.Property(e => e.RequestAmount).HasColumnName("Request_Amount");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Request_Detail_dbo.Product_ProductId");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RequestDetail)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_dbo.Request_Detail_dbo.Request_RequestId");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultPageId).HasColumnName("DefaultPageID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LastModificationDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.DefaultPage)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.DefaultPageId)
                    .HasConstraintName("FK_Role_DefaultPage");
            });

            modelBuilder.Entity<Territories>(entity =>
            {
                entity.HasKey(e => e.TerritoryId)
                    .HasName("PK_dbo.Territories");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.Territories_dbo.Territories_ParentId");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Cycle)
                    .WithMany(p => p.Transaction)
                    .HasForeignKey(d => d.CycleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.Transaction_dbo.Cycles_CycleId");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.TransactionFromUser)
                    .HasForeignKey(d => d.FromUserId)
                    .HasConstraintName("FK_dbo.Transaction_dbo.USERS_FromUserId");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.TransactionToUser)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK_dbo.Transaction_dbo.USERS_ToUserId");
            });

            modelBuilder.Entity<TransactionDetail>(entity =>
            {
                entity.ToTable("Transaction_Detail");

                entity.Property(e => e.TransAmount).HasColumnName("Trans_Amount");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TransactionDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Transaction_Detail_dbo.Product_ProductId");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionDetail)
                    .HasForeignKey(d => d.TransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionDetails_TransactionId");
            });

            modelBuilder.Entity<UserClearance>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CycleId, e.ProductId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CycleId).HasColumnName("CycleID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ClearanceQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.UserClearance)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClearance_Product");
            });

            modelBuilder.Entity<UserTerritory>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TerritoryId })
                    .HasName("PK_dbo.User_Territory");

                entity.ToTable("User_Territory");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.UserTerritory)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_dbo.User_Territory_dbo.Territories_TerritoryId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTerritory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Territory");
            });
        }
    }
}
