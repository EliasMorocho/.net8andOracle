using Admin.Application.IControllers.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public static class AccountsDependencyContainer
    {
        public static IServiceCollection AccountsDependencyContainerControllers(this IServiceCollection services)
        {
            services.AddScoped<IAccountLoginController, AccountLoginController>();
            services.AddScoped<IAccountListController, AccountListController>();
            services.AddScoped<IAccountRegisterController, AccountRegisterController>();
            services.AddScoped<IAccountByIdController, AccountByIdController>();
            services.AddScoped<IAccountUpdateController, AccountUpdateController>();
            return services;
        }
    }
}