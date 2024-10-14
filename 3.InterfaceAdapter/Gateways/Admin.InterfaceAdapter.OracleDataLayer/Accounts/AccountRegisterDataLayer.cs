namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public class AccountRegisterDataLayer : IAccountRegisterRepository
    {
        private readonly AdminContext _context;

        public AccountRegisterDataLayer(AdminContext context)
        {
            _context = context;
        }

        public async ValueTask<MessageDTO> Handle(AccountRegisterRequest request)
        {
            try
            {
                var existingAccount = await _context.Accounts
                    .FirstOrDefaultAsync(a => a.Email == request.Email);

                if (existingAccount != null)
                {
                    return new MessageDTO
                    {
                        Status = false,
                        Message = "Error al registrar usuario, ya existe."
                    };
                }

                var newAccount = new Domain.Entities.Account
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    PasswordHash = request.Password,
                    Role = request.Role,
                    IsActive = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await _context.Accounts.AddAsync(newAccount);
                await _context.SaveChangesAsync();

                return new MessageDTO
                {
                    Status = true,
                    Message = "User registered successfully"
                };
            }
            catch (Exception)
            {
                return new MessageDTO
                {
                    Status = false,
                    Message = "Failed to register User"
                };
            }
        }
    }
}