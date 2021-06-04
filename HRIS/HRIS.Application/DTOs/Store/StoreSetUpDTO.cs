using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.DTOs
{
   public class StoreSetUpDTO
    {
        public int StoreSetupId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string StorePhone { get; set; }
        public string StoreEmail { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
