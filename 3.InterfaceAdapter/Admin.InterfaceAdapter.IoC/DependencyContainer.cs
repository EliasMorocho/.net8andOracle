using Admin.Application.UseCases;
using Admin.InterfaceAdapter.Controllers;
using Admin.InterfaceAdapter.OracleDataLayer;
using Admin.InterfaceAdapter.Presenters;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Admin.InterfaceAdapter.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services
               
               .AddOracleDataLayerService(configuration)
               //.AddPostgreSQLDataLayerService(configuration)
               //.AddSQLDataLayerService(configuration)
               //.AddMySqlDataLayerService(configuration)
               .AddControllersService()
               .AddPresentersService()
               .AddServiceUseCase()
         ;
            return services;
        }
    }
}