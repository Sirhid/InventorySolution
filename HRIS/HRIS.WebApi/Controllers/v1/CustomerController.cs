using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Customer;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HRIS.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Authorize]
    public class CustomerController : BaseApiController
    {
        private readonly ICustomerService _CustomerService;

        public CustomerController(ICustomerService CustomerService)
        {
            _CustomerService = CustomerService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] CreateCustomerDTO request)
        {
            var response = _CustomerService.CreateCustomer(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Customer was created successfully"));
            else if (response == 0)
                return Ok(ResponseHelper.FailureMessage("Failure creating Customer"));
            return Ok(ResponseHelper.AlreadyExistMessage("You are already registered with us"));
        }
        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] UpdateCustomerDTO request)
        {
            var response = _CustomerService.UpdateCustomer(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Customer was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Customer"));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete([FromBody] DeleteCustomerDTO request)
        {
            var response = _CustomerService.DeleteCustomer(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Customer was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Customer"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<CustomerDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _CustomerService.GetAllCustomer();
            if (response != null)
                return Ok(new Response<List<CustomerDTO>>
                {
                    Data = response,
                    Message = "Customer list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Customer"));
        }
        [HttpGet("customerId")]
        [ProducesResponseType(typeof(Response<List<CustomerDTO>>), 200)]
        public IActionResult GetById(int customerId)
        {
            var response = _CustomerService.GetCustomerById(customerId);
            if (response != null)
                return Ok(new Response<CustomerDTO>
                {
                    Data = response,
                    Message = "Customer was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Customer"));
        }
    }
}
