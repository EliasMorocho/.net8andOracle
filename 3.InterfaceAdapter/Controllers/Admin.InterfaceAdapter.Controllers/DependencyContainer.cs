using Admin.InterfaceAdapter.Controllers.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.InterfaceAdapter.Controllers
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddControllersService(this IServiceCollection services)
        {
            services
                .AccountsDependencyContainerControllers()
               
               ;
            return services;
        }
    }
}