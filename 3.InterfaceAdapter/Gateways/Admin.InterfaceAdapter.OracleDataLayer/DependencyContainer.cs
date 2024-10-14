using Admin.InterfaceAdapter.OracleDataLayer.Accounts;

namespace Admin.InterfaceAdapter.OracleDataLayer
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddOracleDataLayerService(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<AdminContext>(options => options.UseOracle(configuration.GetConnectionString("oracleConnection")))

                        .AddScoped<DbInitializer>()
                .AccountsDependencyContainerDataLayer()
            ;
            return services;
        }
    }
}