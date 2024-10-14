using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

using Microsoft.Extensions.DependencyInjection;

namespace Admin.InterfaceAdapter.Presenters.Accounts
{
    public static class AccountsDependencyContainer
    {
        public static IServiceCollection AccountsDependencyContainerPresenters(this IServiceCollection services)
        {
            services.AddScoped<AccountLoginPresenter>();
            services.AddTransient<IAccountLoginPresenter>(proveedor => proveedor.GetService<AccountLoginPresenter>());
            services.AddTransient<IAccountLoginOutputPort>(proveedor => proveedor.GetService<AccountLoginPresenter>());
            services.AddScoped<AccountListPresenter>();
            services.AddTransient<IAccountListPresenter>(proveedor => proveedor.GetService<AccountListPresenter>());
            services.AddTransient<IAccountListOutputPort>(proveedor => proveedor.GetService<AccountListPresenter>());
            services.AddScoped<AccountRegisterPresenter>();
            services.AddTransient<IAccountRegisterPresenter>(proveedor => proveedor.GetService<AccountRegisterPresenter>());
            services.AddTransient<IAccountRegisterOutputPort>(proveedor => proveedor.GetService<AccountRegisterPresenter>());
            services.AddScoped<AccountByIdPresenter>();
            services.AddTransient<IAccountByIdPresenter>(proveedor => proveedor.GetService<AccountByIdPresenter>());
            services.AddTransient<IAccountByIdOutputPort>(proveedor => proveedor.GetService<AccountByIdPresenter>());
            services.AddScoped<AccountUpdatePresenter>();
            services.AddTransient<IAccountUpdatePresenter>(proveedor => proveedor.GetService<AccountUpdatePresenter>());
            services.AddTransient<IAccountUpdateOutputPort>(proveedor => proveedor.GetService<AccountUpdatePresenter>());

            return services;
        }
    }
}