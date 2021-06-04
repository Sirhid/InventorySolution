using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Products;
using HRIS.Application.Wrappers;
using HRIS.Infrastructure.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebApi.Controllers.Product
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ProductsController : BaseApiController
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;

        }

        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] ProductDTO request)
        {
            var response = _productsRepository.CreateProduct(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Product was created successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure creating Product"));
        }

        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] UpdateProductDTO request)
        {
            var response = _productsRepository.UpdateProduct(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Product was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Product"));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete(int ProductID)
        {
            var response = _productsRepository.DeleteProduct(ProductID);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Product was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Product"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<ProductDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _productsRepository.GetAllProducts();
            if (response != null)
                return Ok(new Response<List<ProductDTO>>
                {
                    Data = response,
                    Message = "Products list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving category"));
        }
        [HttpGet("ProductID")]
        [ProducesResponseType(typeof(Response<List<ProductDTO>>), 200)]
        public IActionResult GetById(int ProductID)
        {
            var response = _productsRepository.GetProductByID(ProductID);
            if (response != null)
                return Ok(new Response<ProductDTO>
                {
                    Data = response,
                    Message = "Product was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Products"));
        }
    }
}
