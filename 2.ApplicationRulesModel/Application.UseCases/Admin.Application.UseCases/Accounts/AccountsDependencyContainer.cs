using Admin.Application.IPorts.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.Application.UseCases.Accounts
{
    public static class AccountsDependencyContainer
    {
        public static IServiceCollection AccountsDependencyContainerUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAccountLoginInputPort, AccountLoginInteractor>();
            services.AddScoped<IAccountListInputPort, AccountListInteractor>();
            services.AddScoped<IAccountRegisterInputPort, AccountRegisterInteractor>();
            services.AddScoped<IAccountByIdInputPort, AccountByIdInteractor>();
            services.AddScoped<IAccountUpdateInputPort, AccountUpdateInteractor>();
            return services;
        }
    }
}