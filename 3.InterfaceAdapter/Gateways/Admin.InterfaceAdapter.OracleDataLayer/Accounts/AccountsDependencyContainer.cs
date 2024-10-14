namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public static class AccountsDependencyContainer
    {
        public static IServiceCollection AccountsDependencyContainerDataLayer(this IServiceCollection services)
        {
            services.AddScoped<IAccountLoginRepository, AccountLoginDataLayer>();
            services.AddScoped<IAccountListRepository, AccountListDataLayer>();
            services.AddScoped<IAccountRegisterRepository, AccountRegisterDataLayer>();
            services.AddScoped<IAccountByIdRepository, AccountByIdDataLayer>();
            services.AddScoped<IAccountUpdateRepository, AccountUpdateDataLayer>();
            return services;
        }
    }
}