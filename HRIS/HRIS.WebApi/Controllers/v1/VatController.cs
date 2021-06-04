using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Vat;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VatController : ControllerBase
    {
        private readonly IVatService vatService;
        public VatController(IVatService vatService)
        {
            this.vatService = vatService;
        }

        [HttpPost("CreateVat")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult CreateVat([FromBody] CreateVatDTO request)
        {
            var response = vatService.CreateVat(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Vat was created successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure creating Vat"));
        }
        
        [HttpPut("UpdateVat")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult UpdateVat([FromBody] UpdateVatDTO request)
        {
            var response = vatService.UpdateVat(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Vat was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Vat"));
        }

        [HttpDelete("RemoveVat")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult RemoveVat([FromBody] DeleteVatDTO request)
        {
            var response = vatService.DeleteVat(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Vat was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Vat"));
        }

        [HttpGet("GetAllVat")]
        [ProducesResponseType(typeof(Response<List<VatDTO>>), 200)]
        public IActionResult Get()
        {
            var response = vatService.GetAllVat();
            if (response != null)
                return Ok(new Response<List<VatDTO>>
                {
                    Data = response,
                    Message = "Vat list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Vat"));
        }

        [HttpGet("GetVat")]
        [ProducesResponseType(typeof(Response<List<VatDTO>>), 200)]
        public IActionResult GetById([FromHeader]int VatId)
        {
            var response = vatService.GetVatById(VatId);
            if (response != null)
                return Ok(new Response<VatDTO>
                {
                    Data = response,
                    Message = "Vat was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Vat"));
        }
    }
}
