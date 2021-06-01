using System.Collections.Generic;

namespace HRIS.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<CustomerVoucher> CustomerVouchers { get; set; }
    }
}
