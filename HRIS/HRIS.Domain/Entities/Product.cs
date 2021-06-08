using System;

namespace HRIS.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public double Quantity { get; set; }
        public double Discount { get; set; }
        public bool CanExpire { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int? ProductTypeVariationId { get; set; }
        public string MeasureQuantity { get; set; }
        public string Location { get; set; }
        public int CriticalLevel { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }


        public ProductTypeVariation ProductVariation { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
