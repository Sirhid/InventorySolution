using HRIS.Application;
using HRIS.Application.Interfaces;
using HRIS.Application.Interfaces.Repositories;
using HRIS.Infrastructure.Identity;
using HRIS.Infrastructure.Interfaces.Repositories;
using HRIS.Infrastructure.Persistence;
using HRIS.Infrastructure.Shared;
using HRIS.Infrastructure.Shared.Services;
using HRIS.WebApi.Extensions;
using HRIS.WebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HRIS.WebApi
{
    public class Startup
    {
        public IConfiguration _config { get; }
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            services.AddTransient<IExpenditureRepository, ExpenditureRepository>();
            services.AddTransient<IStoreSetupRepository, StoreSetupRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddApplicationLayer();
            services.AddIdentityInfrastructure(_config);
            services.AddPersistenceInfrastructure(_config);
            services.AddScoped<IAuthenticatedUserService, AuthenticatedUserService>();
            services.AddSharedInfrastructure(_config);
            services.AddSwaggerExtension();
            services.AddControllers();
            services.AddApiVersioningExtension();
            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwaggerExtension();
            app.UseErrorHandlingMiddleware();
            app.UseHealthChecks("/health");

            app.UseEndpoints(endpoints =>
             {
                 endpoints.MapControllers();
             });
        }
    }
}
