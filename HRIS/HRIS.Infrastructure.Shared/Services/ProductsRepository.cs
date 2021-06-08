using Dapper;
using HRIS.Application.AppContants;
using HRIS.Application.DapperServices;
using HRIS.Application.DTOs.Products;
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
   public class ProductsRepository : IProductsRepository
    {
        private readonly ILogger<ProductsRepository> _logger;
        private readonly IAuthenticatedUserService _authenticatedUser;
        private string constring;
        IOptions<ConnectionStrings> myconnectionString;
        private readonly IDapper _dapper;
        public ProductsRepository(ILogger<ProductsRepository> logger,
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

        public int CreateProduct(ProductDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.INSERT);
                param.Add("Description", model.Description);
                param.Add("CanExpire", model.CanExpire);
                param.Add("CategoryId", model.CategoryId);
                param.Add("CostPrice", model.CostPrice);
                param.Add("CreatedOn", model.CreatedOn);
                param.Add("CriticalLevel", model.CriticalLevel);
                param.Add("Discount", model.Discount);
                param.Add("Location", model.Location);
                param.Add("ManufactureDate", model.ManufactureDate);
                param.Add("MeasureQuantity", model.MeasureQuantity);
                param.Add("Name", model.Name);
                param.Add("ProductTypeVariationId", model.ProductTypeVariationId);
                param.Add("Quantity", model.Quantity);
                param.Add("SellingPrice", model.SellingPrice);
                param.Add("SubCategoryId", model.SubCategoryId);
                param.Add("ExpiryDate", model.ExpiryDate);
                param.Add("CreatedBy", _authenticatedUser.UserId);
                var response = _dapper.Execute(ApplicationConstant.Sp_Product, param, CommandType.StoredProcedure);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while saving category");
                return 0;
            }
        }

        public int DeleteProduct(int productID)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.DELETE);
                param.Add("ProductID", productID);
                param.Add("DeletedBy", _authenticatedUser.UserId);

                var response = _dapper.Execute(ApplicationConstant.Sp_Product, param, CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while deleting category");
                return 0;
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", Status.GETALL);
                var response = _dapper.GetAll<ProductDTO>(ApplicationConstant.Sp_Product, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a category");
                return null;
            }
        }

        public ProductDTO GetProductByID(int ProductID)
        {
            try
            {

                var param = new DynamicParameters();
                param.Add("Status", Status.GETBYID);
                param.Add("ProductID", ProductID);
                var response = _dapper.Get<ProductDTO>(ApplicationConstant.Sp_Product, param, commandType: CommandType.StoredProcedure);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a category");
                return new ProductDTO();
            }
        }

        public int UpdateProduct(UpdateProductDTO model)
        {
            try
            {
                var param = new DynamicParameters();
                param.Add("Status", Status.UPDATE);
                param.Add("CategoryId", model.CategoryId);
                param.Add("SubCategoryId", model.SubCategoryId);
                param.Add("CanExpire", model.CanExpire);
                param.Add("CostPrice", model.CostPrice);
                param.Add("CriticalLevel", model.CriticalLevel);
                param.Add("Discount", model.Discount);
                param.Add("ExpiryDate", model.ExpiryDate);
                param.Add("Location", model.Location);
                param.Add("ManufactureDate", model.ManufactureDate);
                param.Add("MeasureQuantity", model.MeasureQuantity);
                param.Add("Description", model.Description);
                param.Add("Name", model.Name);
                param.Add("ProductId", model.ProductId);
                param.Add("ProductTypeVariationId", model.ProductTypeVariationId);
                param.Add("Quantity", model.Quantity);
                param.Add("SellingPrice", model.SellingPrice);
                param.Add("UpdatedOn", model.UpdatedOn);
                param.Add("UpdatedBy", _authenticatedUser.UserId);
                var response = _dapper.Execute(ApplicationConstant.Sp_Product, param, CommandType.StoredProcedure);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured while updating a category");
                return 0;
            }
        }
    }
}
