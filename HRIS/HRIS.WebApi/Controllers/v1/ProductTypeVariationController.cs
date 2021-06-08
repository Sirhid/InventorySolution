using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.ProductTypeVariation;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ProductTypeVariationController : BaseApiController
    {
        private readonly IProductTypeVariationService _productTypeVariationService;

        public ProductTypeVariationController(IProductTypeVariationService ProductTypeVariationService)
        {
            _productTypeVariationService = ProductTypeVariationService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] CreateProductTypeVariationDTO request)
        {
            var response = _productTypeVariationService.CreateProductTypeVariation(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("ProductTypeVariation was created successfully"));
            else if (response == 0)
                return Ok(ResponseHelper.FailureMessage("Failure creating ProductTypeVariation"));
            return Ok(ResponseHelper.AlreadyExistMessage("Product type Variation already exist"));
        }
        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] UpdateProductTypeVariationDTO request)
        {
            var response = _productTypeVariationService.UpdateProductTypeVariation(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Product Type Variation was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating ProductTypeVariation"));

        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete([FromBody] DeleteProductTypeVariationDTO request)
        {
            var response = _productTypeVariationService.DeleteProductTypeVariation(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("ProductTypeVariation was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting ProductTypeVariation"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<ProductTypeVariationDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _productTypeVariationService.GetAllProductTypeVariation();
            if (response != null)
                return Ok(new Response<List<ProductTypeVariationDTO>>
                {
                    Data = response,
                    Message = "ProductTypeVariation list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving ProductTypeVariation"));
        }
        [HttpGet("ProductTypeVariationId")]
        [ProducesResponseType(typeof(Response<List<ProductTypeVariationDTO>>), 200)]
        public IActionResult GetById(int ProductTypeVariationId)
        {
            var response = _productTypeVariationService.GetProductTypeVariationById(ProductTypeVariationId);
            if (response != null)
                return Ok(new Response<ProductTypeVariationDTO>
                {
                    Data = response,
                    Message = "ProductTypeVariation was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving ProductTypeVariation"));
        }
    }
}
