using HRIS.Application.DTOs.Products;
using System.Collections.Generic;

namespace HRIS.Infrastructure.Interfaces.Repositories
{
   public interface IProductsRepository
    {
        int CreateProduct(ProductDTO model);
        int DeleteProduct(int productID);
        List<ProductDTO> GetAllProducts();
        ProductDTO GetProductByID(int ProductID);
        int UpdateProduct(UpdateProductDTO model);
    }
}