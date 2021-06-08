using Dapper;
using HRIS.Application.AppContants;
using HRIS.Application.DapperServices;
using HRIS.Application.DTOs.Account;
using HRIS.Application.Enums;
using HRIS.Application.Interfaces;
using HRIS.Domain.Common;
using HRIS.Infrastructure.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRIS.Infrastructure.Shared.Services
{
    public class MenuRepository : IMenuRepository
    {
        private readonly ILogger<MenuRepository> _logger;
        private readonly IAuthenticatedUserService _authenticatedUser;
        private string constring;
        IOptions<ConnectionStrings> myconnectionString;
        private readonly IDapper _dapper;
        public MenuRepository(ILogger<MenuRepository> logger,
                             IAuthenticatedUserService authenticatedUser,
                             IOptions<ConnectionStrings> connectionString,
                             IDapper dapper)
        {
            _logger = logger;
            _authenticatedUser = authenticatedUser;
            myconnectionString = connectionString;
            _dapper = dapper;
            constring = myconnectionString.Value.DefaultConnection;
        }

        public List<MenuRole> GetMenu(int RoleID)
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", 2);
                param.Add("RoleID", RoleID);
                var response = _dapper.GetAll<MenuRole>(ApplicationConstant.Sp_MenuSetup, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while getting a Menu");
                return new List<MenuRole>();
            }
        }

        public List<PermissionDTO> GetPermissionbyUserID(int UserID)
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", 1);
                param.Add("UserID", UserID);
                var response = _dapper.GetAll<PermissionDTO>(ApplicationConstant.Sp_MenuSetup, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while loading permission");
                return new List<PermissionDTO>();
            }
        }
    }
}
