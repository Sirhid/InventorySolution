using System;

namespace HRIS.Domain.Entities
{
    public class Sales : BaseEntity
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
        public double SellingPrice { get; set; }
        public double VAT { get; set; }
        public int CustomerId { get; set; }
        public bool IsVoucherUsed { get; set; }
        public int? CustomerVoucherId { get; set; }
        public bool IsPaid { get; set; }
        public string RecieptNumber { get; set; }
        public string BillNumber { get; set; }
        public DateTime DatePaid { get; set; }
    }
}
