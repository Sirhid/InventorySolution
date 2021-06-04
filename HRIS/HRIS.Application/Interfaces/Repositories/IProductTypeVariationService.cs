using HRIS.Application.DTOs.ProductTypeVariation;
using System.Collections.Generic;

namespace HRIS.Application.Interfaces.Repositories
{
    public interface IProductTypeVariationService
    {
        int CreateProductTypeVariation(CreateProductTypeVariationDTO model);
        int UpdateProductTypeVariation(UpdateProductTypeVariationDTO model);
        int DeleteProductTypeVariation(DeleteProductTypeVariationDTO model);
        List<ProductTypeVariationDTO> GetAllProductTypeVariation();
        ProductTypeVariationDTO GetProductTypeVariationById(int productTypeVariationId);
    }
}
