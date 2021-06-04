using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.DTOs.Voucher
{
    public class CreateVoucherDTO
    {
       
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
