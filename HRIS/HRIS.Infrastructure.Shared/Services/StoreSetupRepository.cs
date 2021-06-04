using Dapper;
using HRIS.Application.AppContants;
using HRIS.Application.DapperServices;
using HRIS.Application.DTOs;
using HRIS.Application.DTOs.Store;
using HRIS.Application.Enums;
using HRIS.Application.Interfaces;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Domain.Common;
using HRIS.Domain.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRIS.Infrastructure.Shared.Services
{
    public class StoreSetupRepository : IStoreSetupRepository
    {

        private readonly ILogger<StoreSetupRepository> _logger;
        private readonly IAuthenticatedUserService _authenticatedUser;
        private string constring;
        IOptions<ConnectionStrings> myconnectionString;
        private readonly IDapper _dapper;
        public StoreSetupRepository(ILogger<StoreSetupRepository> logger,
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
        public int CreateStore(StoreSetUpDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.INSERT);
                param.Add("CreatedOn", model.CreatedOn);
                param.Add("DeletedBy", model.DeletedBy);
                param.Add("DeletedOn", model.DeletedOn);
                param.Add("IsDeleted", model.IsDeleted);
                param.Add("StoreAddress", model.StoreAddress);
                param.Add("StoreEmail", model.StoreEmail);
                param.Add("StoreName", model.StoreName);
                param.Add("StorePhone", model.StorePhone);
                param.Add("CreatedBy", _authenticatedUser.UserId);
                var response = _dapper.Execute(ApplicationConstant.Sp_StoreSetup, param, CommandType.StoredProcedure);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while saving Store");
                return 0;
            }
        }

        //public int DeleteExpenditure(int StoreID)
        //{
        //    try
        //    {
        //        var param = new DynamicParameters();
        //        param.Add("Status", Status.DELETE);
        //        param.Add("StoreID", StoreID);
        //        param.Add("DeletedBy", _authenticatedUser.UserId);
        //        var response = _dapper.Execute(ApplicationConstant.Sp_Product, param, CommandType.StoredProcedure);
        //        return response;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occured while deleting Store");
        //        return 0;
        //    }
        //}

        public List<StoreSetUpDTO> GetAllStores()
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", Status.GETALL);
                var response = _dapper.GetAll<StoreSetUpDTO>(ApplicationConstant.Sp_StoreSetup, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a Store");
                return null;
            }
        }

        public StoreSetUpDTO GetStoreByID(int StoreID)
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", Status.GETBYID);
                param.Add("StoreID", StoreID);
                var response = _dapper.Get<StoreSetUpDTO>(ApplicationConstant.Sp_StoreSetup, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a Store");
                return new StoreSetUpDTO();
            }
        }

        public int UpdateStore(StoreUpdateDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.UPDATE);
                param.Add("StoreSetupId", model.StoreSetupId);
                param.Add("StoreAddress", model.StoreAddress);
                param.Add("StoreEmail", model.StoreEmail);
                param.Add("StoreName", model.StoreName);
                param.Add("StorePhone", model.StorePhone);                
                param.Add("UpdatedOn", model.UpdatedOn);
                param.Add("UpdatedBy", _authenticatedUser.UserId);
                var response = _dapper.Execute(ApplicationConstant.Sp_StoreSetup, param, CommandType.StoredProcedure);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a Store");
                return 0;
            }
        }
    }
}
