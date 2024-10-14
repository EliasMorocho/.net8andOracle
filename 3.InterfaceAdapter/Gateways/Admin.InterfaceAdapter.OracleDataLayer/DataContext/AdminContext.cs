namespace Admin.InterfaceAdapter.OracleDataLayer.DataContext
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}