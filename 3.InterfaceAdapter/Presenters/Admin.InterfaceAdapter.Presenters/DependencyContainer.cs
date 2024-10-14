using Admin.InterfaceAdapter.Presenters.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.InterfaceAdapter.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersService(this IServiceCollection services)
        {
            services
                .AccountsDependencyContainerPresenters()
               
               ;
            return services;
        }
    }
}