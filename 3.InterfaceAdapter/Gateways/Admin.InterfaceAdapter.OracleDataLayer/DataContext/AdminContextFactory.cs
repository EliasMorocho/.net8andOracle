using Microsoft.EntityFrameworkCore.Design;

namespace Admin.InterfaceAdapter.OracleDataLayer.DataContext
{
    public class AdminContextFactory : IDesignTimeDbContextFactory<AdminContext>
    {
        //dotnet ef migrations add InitialCreate --project Admin.InterfaceAdapter.OracleDataLayer
        //dotnet ef database update --project Admin.InterfaceAdapter.OracleDataLayer
        public AdminContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<AdminContext>();
            OptionsBuilder.UseOracle("Data Source=localhost:1521/xe;Persist Security Info=True;User ID=SYSTEM;Password=123;");
            return new AdminContext(OptionsBuilder.Options);
        }
    }
}