using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.DTOs.Products
{
   public class ProductDTO
    {
        public int ProductId { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float CostPrice { get; set; }
        public float Discount { get; set; }
        public float Quantity { get; set; }
        public float SellingPrice { get; set; }
        public bool CanExpire { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string MeasureQuantity { get; set; }
        public string Location { get; set; }
        public string CriticalLevel { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int ProductTypeVariationId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

    }
}
