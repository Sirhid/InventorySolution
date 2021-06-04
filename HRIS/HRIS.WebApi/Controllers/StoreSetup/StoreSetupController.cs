using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs;
using HRIS.Application.DTOs.Store;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Application.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebApi.Controllers.StoreSetup
{
    [ApiVersion("1.0")]
    [Authorize]
    public class StoreSetupController : BaseApiController
    {
        private readonly IStoreSetupRepository _StoreRepository;

        public StoreSetupController(IStoreSetupRepository StoreRepository)
        {
            _StoreRepository = StoreRepository;

        }


        [HttpPost]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Post([FromBody] StoreSetUpDTO request)
        {
            var response = _StoreRepository.CreateStore(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Store was created successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure creating Store"));
        }

        [HttpPut]
        [ProducesResponseType(typeof(Response<string>), 200)]
        public IActionResult Put([FromBody] StoreUpdateDTO request)
        {
            var response = _StoreRepository.UpdateStore(request);
            if (response > 0)
                return Ok(ResponseHelper.SuccessMessage("Store was updated successfully"));
            return Ok(ResponseHelper.FailureMessage("Failure updating Store"));
        }

       
        [HttpGet]
        [ProducesResponseType(typeof(Response<List<StoreSetUpDTO>>), 200)]
        public IActionResult Get()
        {
            var response = _StoreRepository.GetAllStores();
            if (response != null)
                return Ok(new Response<List<StoreSetUpDTO>>
                {
                    Data = response,
                    Message = "Store list was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Stores"));
        }
        [HttpGet("StoreID")]
        [ProducesResponseType(typeof(Response<List<StoreSetUpDTO>>), 200)]
        public IActionResult GetById(int StoreID)
        {
            var response = _StoreRepository.GetStoreByID(StoreID);
            if (response != null)
                return Ok(new Response<StoreSetUpDTO>
                {
                    Data = response,
                    Message = "Store was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Store"));
        }
    }
}
