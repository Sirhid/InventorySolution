using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Expenditure;
using HRIS.Application.Wrappers;
using HRIS.Infrastructure.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebApi.Controllers.Expenditure
{
    [ApiVersion("1.0")]
    [Authorize]
    public class ExpenditureController : BaseApiController
    {
        private readonly IExpenditureRepository _ExpenditureRepository;

        public ExpenditureController(IExpenditureRepository ExpenditureRepository)
        {
            _ExpenditureRepository = ExpenditureRepository;

        }
        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] ExpenditureDTO request)
        {
            var response = _ExpenditureRepository.CreateExpenditure(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Expenditure was created successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure creating Expenditure"));
        }

        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] UpdateExpenditureDTO request)
        {
            var response = _ExpenditureRepository.UpdateExpenditure(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Expenditure was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Expenditure"));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Delete(int ExpenditureID )
        {
            var response = _ExpenditureRepository.DeleteExpenditure(ExpenditureID);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Expenditure was deleted successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure deleting Expenditure"));
        }
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<ExpenditureDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _ExpenditureRepository.GetAllExpenditure();
            if (response != null)
                return Ok(new Response<List<ExpenditureDTO>>
                {
                    Data = response,
                    Message = "Expenditure list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Expenditure"));
        }
        [HttpGet("ExpenditureID")]
        [ProducesResponseType(typeof(Response<List<ExpenditureDTO>>), 200)]
        public IActionResult GetById(int ExpenditureID)
        {
            var response = _ExpenditureRepository.GetExpenditureByID(ExpenditureID);
            if (response != null)
                return Ok(new Response<ExpenditureDTO>
                {
                    Data = response,
                    Message = "Expenditure was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Expenditure"));
        }
    }
}
