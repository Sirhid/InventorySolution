using System.Collections.Generic;

namespace HRIS.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public int SubCategoryId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
