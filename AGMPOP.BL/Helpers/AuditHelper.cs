using AGMPOP.BL.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AGMPOP.BL.Models.ViewModels.POPEnums;

namespace AGMPOP.BL.Helpers
{
    public class DataAuditEntry
    {
        public EntityEntry Entry { get; }
        public string TableName { get; set; }
        public string SessionId { get; set; }
        public Dictionary<string, object> KeyValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public AuditActionType ActionType { get; set; }

        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public DataAuditEntry(EntityEntry entry)
        {
            Entry = entry;
            TableName = entry.Entity.GetType().Name;
        }

        public DataAudit ToAudit()
        {
            var audit = new DataAudit
            {
                TableName = TableName,
                ObjectKey = JsonConvert.SerializeObject(KeyValues),
                OldData = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues),
                NewData = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues),
                UserId = UserId,
                Date = Time,
                SessionId = SessionId,
                ActionTypeId = (int)ActionType,
            };
            return audit;
        }
    }

    public class AuditHelper
    {
        private readonly int _userId;
        private readonly AGMPOPContext _context;

        public AuditHelper(AGMPOPContext context, int userId)
        {
            _context = context;
            _userId = userId;
        }

        public List<DataAuditEntry> OnBeforeSaveChanges()
        {
            _context.ChangeTracker.DetectChanges();
            var result = new List<DataAuditEntry>();
            try
            {
                var entries = _context.ChangeTracker.Entries()
                                     .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted)
                                     .Where(e => !(e.Entity is DataAudit || e.Entity is Notifications))
                                     .ToArray();

                var sessionId = Guid.NewGuid().ToString();
                var now = DateTime.Now;

                foreach (var entry in entries)
                {
                    var item = new DataAuditEntry(entry)
                    {
                        Time = now,
                        UserId = _userId,
                        SessionId = sessionId,
                    };
                    bool onlyPrimary = true;
                    bool unchanged = true;
                    var properties = entry.Properties.ToArray();

                    switch (entry.State)
                    {
                        case EntityState.Added:
                            item.ActionType = AuditActionType.Insert;
                            break;
                        case EntityState.Deleted:
                            item.ActionType = AuditActionType.Delete;
                            break;
                        case EntityState.Modified:
                            item.ActionType = AuditActionType.Update;
                            break;
                    }
                    foreach (var prop in properties)
                    {
                        if (prop.IsTemporary)
                        {
                            item.TemporaryProperties.Add(prop);
                            unchanged = false;
                            continue;
                        }
                        var propName = prop.Metadata.Name;
                        if (prop.Metadata.IsPrimaryKey())
                        {
                            item.KeyValues[propName] = prop.CurrentValue;
                            continue;
                        }
                        onlyPrimary = false;
                        switch (entry.State)
                        {
                            case EntityState.Added:
                                item.NewValues[propName] = prop.CurrentValue;
                                unchanged = false;
                                break;

                            case EntityState.Deleted:
                                item.OldValues[propName] = prop.OriginalValue;
                                unchanged = false;
                                break;

                            case EntityState.Modified:
                                if (prop.OriginalValue == null && prop.CurrentValue == null)
                                {
                                    break;
                                }
                                if (prop.OriginalValue?.Equals(prop.CurrentValue) != true)
                                {
                                    item.OldValues[propName] = prop.OriginalValue;
                                    item.NewValues[propName] = prop.CurrentValue;
                                    unchanged = false;
                                }
                                break;
                        }
                    }
                    if (onlyPrimary || !unchanged)
                    {
                        result.Add(item);
                    }
                }
                _context.DataAudit.AddRange(result.Where(_ => !_.HasTemporaryProperties).Select(_ => _.ToAudit()));
                return result.Where(_ => _.HasTemporaryProperties)
                             .ToList();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public void OnAfterSaveChanges(List<DataAuditEntry> auditEntries)
        {
            if (auditEntries == null || auditEntries.Count == 0)
                return;

            for (int i = 0; i < auditEntries.Count; i++)
            {
                var auditEntry = auditEntries[i];
                for (int j = 0; j < auditEntry.TemporaryProperties.Count; j++)
                {
                    var prop = auditEntry.TemporaryProperties[j];
                    if (prop.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[prop.Metadata.Name] = prop.CurrentValue;
                    }
                    else
                    {
                        auditEntry.NewValues[prop.Metadata.Name] = prop.CurrentValue;
                    }
                }

                _context.DataAudit.Add(auditEntry.ToAudit());
            }

            _context.SaveChanges();
        }
    }
}
