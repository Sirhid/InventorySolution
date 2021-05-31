using AutoMapper;
using HRIS.Application.Features.Products.Commands.CreateProduct;
using HRIS.Application.Features.Products.Queries.GetAllProducts;
using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
