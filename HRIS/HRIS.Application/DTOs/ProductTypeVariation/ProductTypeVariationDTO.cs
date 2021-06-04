using System;

namespace HRIS.Application.DTOs.ProductTypeVariation
{
    public class ProductTypeVariationDTO
    {
        public int ProductTypeVariationId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
