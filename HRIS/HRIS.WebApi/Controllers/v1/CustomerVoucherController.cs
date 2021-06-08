using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.CustomerVoucher;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CustomerVoucherController : BaseApiController
    {
        private readonly ICustomerVoucherService _customerVoucherService;

        public CustomerVoucherController(ICustomerVoucherService CustomerVoucherService)
        {
            _customerVoucherService = CustomerVoucherService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] CreateCustomerVoucherDTO request)
        {
            var response = _customerVoucherService.CreateCustomerVoucher(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("CustomerVoucher was created successfully"));
            else if (response == 0)
                return Ok(ResponseHelper.FailureMessage("Failure creating CustomerVoucher"));
            return Ok(ResponseHelper.AlreadyExistMessage("Customer has been previously assigned the voucher"));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete([FromBody] DeleteCustomerVoucherDTO request)
        {
            var response = _customerVoucherService.DeleteCustomerVoucher(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("CustomerVoucher was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting CustomerVoucher"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<CustomerVoucherDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _customerVoucherService.GetAllCustomerVoucher();
            if (response != null)
                return Ok(new Response<List<CustomerVoucherDTO>>
                {
                    Data = response,
                    Message = "CustomerVoucher list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving CustomerVoucher"));
        }
        [HttpGet("CustomerVoucherId")]
        [ProducesResponseType(typeof(Response<List<CustomerVoucherDTO>>), 200)]
        public IActionResult GetById(int CustomerVoucherId)
        {
            var response = _customerVoucherService.GetCustomerVoucherById(CustomerVoucherId);
            if (response != null)
                return Ok(new Response<CustomerVoucherDTO>
                {
                    Data = response,
                    Message = "CustomerVoucher was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving CustomerVoucher"));
        }
    }
}
