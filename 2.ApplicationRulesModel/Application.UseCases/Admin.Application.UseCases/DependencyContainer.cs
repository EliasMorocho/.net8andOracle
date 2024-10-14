using Admin.Application.UseCases.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.Application.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServiceUseCase(this IServiceCollection services)
        {
            services
               .AccountsDependencyContainerUseCases()
                          ;

            return services;
        }
    }
}