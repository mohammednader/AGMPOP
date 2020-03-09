using System;
using System.Collections.Generic;

namespace AGMPOP.BL.Models.Domain
{
    public partial class AppUser
    {
        public AppUser()
        {
            CycleUser = new HashSet<CycleUser>();
            DataAudit = new HashSet<DataAudit>();
            LnkUserRole = new HashSet<LnkUserRole>();
            Notifications = new HashSet<Notifications>();
            Request = new HashSet<Request>();
            TransactionFromUser = new HashSet<Transaction>();
            TransactionToUser = new HashSet<Transaction>();
            UserTerritory = new HashSet<UserTerritory>();
        }

        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSysAdmin { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModificationDate { get; set; }
        public bool? IsChangedPassword { get; set; }
        public bool? IsEmailConfirmed { get; set; }
        public bool? IsPhoneNumberConfirmed { get; set; }
        public bool? IsTwoFactorEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? JobTitleId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        public virtual ICollection<CycleUser> CycleUser { get; set; }
        public virtual ICollection<DataAudit> DataAudit { get; set; }
        public virtual ICollection<LnkUserRole> LnkUserRole { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Transaction> TransactionFromUser { get; set; }
        public virtual ICollection<Transaction> TransactionToUser { get; set; }
        public virtual ICollection<UserTerritory> UserTerritory { get; set; }
    }
}
