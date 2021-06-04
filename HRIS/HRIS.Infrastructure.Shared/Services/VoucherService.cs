using Dapper;
using HRIS.Application.AppContants;
using HRIS.Application.DapperServices;
using HRIS.Application.DTOs.Vat;
using HRIS.Application.DTOs.Voucher;
using HRIS.Application.Enums;
using HRIS.Application.Interfaces;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Domain.Common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HRIS.Infrastructure.Shared.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly ILogger<VoucherService> _logger;
        private readonly IAuthenticatedUserService _authenticatedUser;
        private string constring;
        IOptions<ConnectionStrings> myconnectionString;
        private readonly IDapper _dapper;

        public VoucherService(ILogger<VoucherService> logger,
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

        public int CreateVoucher(CreateVoucherDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.INSERT);
                param.Add("Description", model.Description);
                param.Add("amount", model.Amount);
                param.Add("ExpiredDate", model.ExpiryDate);
                param.Add("CreatedBy", _authenticatedUser.UserId);
                var response = _dapper.Execute(ApplicationConstant.SP_Voucher, param, CommandType.StoredProcedure);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while saving voucher");
                return 0;
            }
        }

        public int UpdateVoucher(UpdateVoucherDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.UPDATE);
                param.Add("VoucherID", model.VoucherId);
                param.Add("Description", model.Description);
                param.Add("amount", model.Amount);
                param.Add("ExpiredDate", model.ExpiryDate);
                param.Add("UpdatedBy", _authenticatedUser.UserId);

                var response = _dapper.Execute(ApplicationConstant.SP_Voucher, param, CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a voucher");
                return 0;
            }
        }

        public int DeleteVoucher(DeleteVoucherDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.DELETE);
                param.Add("VoucherID", model.VoucherId);
                param.Add("DeletedBy", _authenticatedUser.UserId);

                var response = _dapper.Execute(ApplicationConstant.SP_Voucher, param, CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while deleting voucher");
                return 0;
            }
        }

        public List<VoucherDTO> GetAllVoucher()
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.GETALL);
                var response = _dapper.GetAll<VoucherDTO>(ApplicationConstant.SP_Voucher, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while returning voucher");
                return null;
            }
        }

        public VoucherDTO GetVoucherById(int VoucherId)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.GETBYID);
                param.Add("VoucherID", VoucherId);
                var response = _dapper.Get<VoucherDTO>(ApplicationConstant.SP_Voucher, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while getting Voucher");
                return new VoucherDTO();
            }
        }
    }
}
