using HRIS.Application.ApiResponseHelpers;
using HRIS.Application.AppContants;
using HRIS.Application.DTOs.Account;
using HRIS.Application.Wrappers;
using HRIS.Infrastructure.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.WebApi.Controllers.Role
{
    [ApiVersion("1.0")]
    [Authorize]
    public class MenuItemController : BaseApiController
    {
        private readonly IMenuRepository _menuRepository;

        public MenuItemController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;

        }
        [HttpGet("RoleID")]
        [ProducesResponseType(typeof(Response<List<MenuRole>>), 200)]
        public IActionResult GetbyID(int RoleID)
        {
            var response = _menuRepository.GetMenu(RoleID);
            if (response != null)
                return Ok(new Response<List<MenuRole>>
                {
                    Data = response,
                    Message = "Menulist was retrieved successfully ",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Menulist"));
        }


        [HttpGet("UserID")]
        [ProducesResponseType(typeof(Response<List<PermissionDTO>>), 200)]
        public IActionResult Get(int UserID)
        {
            var response = _menuRepository.GetPermissionbyUserID(UserID);
            if (response != null)
                return Ok(new Response<List<PermissionDTO>>
                {
                    Data = response,
                    Message = "Permission was retrieved successfully",
                    ResponseCode = ApplicationConstant.SuccessResponseCode,
                    StatusCode = ApplicationConstant.SuccessStatusCode,
                    Succeeded = true
                });
            return Ok(ResponseHelper.FailureMessage("Failure retrieving Permission"));
        }
    }
}
