using Dapper;
using HRIS.Application.AppContants;
using HRIS.Application.DapperServices;
using HRIS.Application.DTOs.Category;
using HRIS.Application.DTOs.Menu;
using HRIS.Application.Enums;
using HRIS.Application.Interfaces;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Domain.Common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;

namespace HRIS.Infrastructure.Shared.Services
{
    public class AssignMenuToService : IAssignMenuToUserService
    {
        private readonly IDapper dapper;
        private readonly ILogger<AssignMenuToService> _logger;
        private readonly IAuthenticatedUserService _authenticatedUser;
        //  private readonly IOptions<ConnectionStrings> _connectionString;
        private string constring;
        IOptions<ConnectionStrings> myconnectionString;
       
        public AssignMenuToService(ILogger<AssignMenuToService> logger,
                               IAuthenticatedUserService authenticatedUser,
                               IOptions<ConnectionStrings> connectionString,
                               IDapper dapper)
        {
            this.dapper =dapper;
            _logger = logger;
            _authenticatedUser = authenticatedUser;
            myconnectionString = connectionString;
            constring = myconnectionString.Value.DefaultConnection;

        }
        public int CreateMenuRequest(MenuRequest model)
        {
            var response = 0;
            try
            {
                model.menus.ForEach(x =>
                {
                    var param = new DynamicParameters();
                    param.Add("Status", Status.INSERT);
                    param.Add("UserId",model.userId);
                    param.Add("menuId",x);
                    param.Add("CreatedBy", _authenticatedUser.UserId);
                    response = dapper.Execute(ApplicationConstant.SP_AssignPermissionToUser, param, CommandType.StoredProcedure);
                    
                });

                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while Assigning menu to users");
                return 0;
            }
            
        }

        public int DeleteMenuRequest(MenuRequest model)
        {
            var response = 0;
            try
            {
                model.menus.ForEach(x =>
                {
                    var param = new DynamicParameters();
                    param.Add("Status", Status.DELETE);
                    param.Add("userId", model.userId);
                    param.Add("menuId", x);
                    param.Add("DeletedBy", _authenticatedUser.UserId);
                    response = dapper.Execute(ApplicationConstant.SP_AssignPermissionToUser, param, CommandType.StoredProcedure);

                });

                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while deleting menu assign to users");
                return 0;
            }
        }

        public int UpdateRequest(MenuRequest model)
        {
            var response = 0;
            try
            {
                model.menus.ForEach(x =>
                {
                    var param = new DynamicParameters();
                    param.Add("Status", Status.INSERT);
                    param.Add("UserId", model.userId);
                    param.Add("menuId", x);
                    param.Add("UpdatedBy", _authenticatedUser.UserId);
                    response = dapper.Execute(ApplicationConstant.SP_AssignPermissionToUser, param, CommandType.StoredProcedure);

                });

                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating Assigning menu to users");
                return 0;
            }
        }
    }
}
