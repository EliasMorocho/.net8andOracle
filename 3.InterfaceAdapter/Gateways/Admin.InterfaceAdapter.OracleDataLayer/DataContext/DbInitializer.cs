namespace Admin.InterfaceAdapter.OracleDataLayer.DataContext
{
    public class DbInitializer
    {
        private readonly AdminContext _dbContext;

        public DbInitializer(AdminContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task InitializeDatabaseAsync()
        {
            await _dbContext.Database.MigrateAsync();
            if (_dbContext.Accounts.Count() <= 0)
            {
                var adminAccount = CreateAdminAccount();
               

                using var transaction = await _dbContext.Database.BeginTransactionAsync();
                try
                {
                    _dbContext.Accounts.Add(adminAccount);
                   

                    await _dbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (DbUpdateException ex)
                {
                    await transaction.RollbackAsync();
                    LogError(ex);
                }
            }
        }

        private Account CreateAdminAccount()
        {
            var adminAccount = new Account
            {
                Email = "admin@gmail.com",
                PasswordHash = "123",  // Asegúrate de cambiar a un hash seguro
                Role = Roles.Administrador,
                CreatedAt = DateTime.UtcNow,
                IsActive = 1,
                FullName = "Administrador del Sistema",
                UpdatedAt = DateTime.UtcNow
            };

            return adminAccount;
        }

        

        private void LogError(DbUpdateException ex)
        {
            Console.WriteLine($"Error al insertar los datos en la base de datos: {ex.Message} - {ex.InnerException?.Message}");
        }
    }
}