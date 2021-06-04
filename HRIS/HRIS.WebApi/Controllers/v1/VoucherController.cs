using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Voucher;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService service;
        public VoucherController(IVoucherService service)
        {
            this.service = service;
        }

        [HttpPost("CreateVoucher")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult CreateVoucher([FromBody] CreateVoucherDTO request)
        {
            var response = service.CreateVoucher(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Voucher was created successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure creating Voucher"));
        }

        [HttpPut("UpdateVoucher")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult UpdateVoucher([FromBody] UpdateVoucherDTO request)
        {
            var response = service.UpdateVoucher(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Voucher was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Voucher"));
        }

        [HttpDelete("RemoveVoucher")]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult RemoveVoucher([FromBody] DeleteVoucherDTO request)
        {
            var response = service.DeleteVoucher(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Voucher was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Voucher"));
        }

        [HttpGet("GetAllVoucher")]
        [ProducesResponseType(typeof(Response<List<VoucherDTO>>), 200)]
        public IActionResult GetAllVoucher()
        {
            var response = service.GetAllVoucher();
            if (response != null)
                return Ok(new Response<List<VoucherDTO>>
                {
                    Data = response,
                    Message = "Voucher list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Voucher"));
        }

        [HttpGet("GetVoucher")]
        [ProducesResponseType(typeof(Response<VoucherDTO>), 200)]
        public IActionResult Get([FromHeader]int VoucherId)
        {
            var response = service.GetVoucherById(VoucherId);
            if (response != null)
                return Ok(new Response<VoucherDTO>
                {
                    Data = response,
                    Message = "Voucher was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Voucher"));
        }
    }
}

