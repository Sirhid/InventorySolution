using System;

namespace HRIS.Domain.Entities
{
    public class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string DeletedBy { get; set; }
    }

    public class ReadConnectionString
    {
        public string ConnectionString { get; set; }
    }
}
