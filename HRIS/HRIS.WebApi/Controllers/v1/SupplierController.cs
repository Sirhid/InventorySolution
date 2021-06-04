using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Supplier;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class SupplierController : BaseApiController
    {
        private readonly ISupplierService _SupplierService;

        public SupplierController(ISupplierService SupplierService)
        {
            _SupplierService = SupplierService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] CreateSupplierDTO request)
        {
            var response = _SupplierService.CreateSupplier(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Supplier was created successfully"));
            else if (response == 0)
                return Ok(ResponseHelper.FailureMessage("Failure creating Supplier"));
            return Ok(ResponseHelper.AlreadyExistMessage("You are already registered with us"));
        }
        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] UpdateSupplierDTO request)
        {
            var response = _SupplierService.UpdateSupplier(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Supplier was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Supplier"));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete([FromBody] DeleteSupplierDTO request)
        {
            var response = _SupplierService.DeleteSupplier(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Supplier was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Supplier"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<SupplierDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _SupplierService.GetAllSupplier();
            if (response != null)
                return Ok(new Response<List<SupplierDTO>>
                {
                    Data = response,
                    Message = "Supplier list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Supplier"));
        }
        [HttpGet("supplierId")]
        [ProducesResponseType(typeof(Response<List<SupplierDTO>>), 200)]
        public IActionResult GetById(int supplierId)
        {
            var response = _SupplierService.GetSupplierById(supplierId);
            if (response != null)
                return Ok(new Response<SupplierDTO>
                {
                    Data = response,
                    Message = "Supplier was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Supplier"));
        }
    }
}
