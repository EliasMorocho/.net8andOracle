namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public class AccountLoginDataLayer : IAccountLoginRepository
    {
        private readonly AdminContext _context;

        public AccountLoginDataLayer(AdminContext context)
        {
            _context = context;
        }

        public async ValueTask<AccountLoginResponse> Handle(AccountLoginRequest request)
        {
            try
            {
                var result = await _context.Accounts
                    .FirstOrDefaultAsync(a => a.Email == request.Email && a.PasswordHash == request.Password);

                if (result != null)
                {
                    return new AccountLoginResponse
                    {
                        IsLogin = true,
                        Username = result.FullName,
                        Email = result.Email,
                        Role = result.Role
                    };
                }

                return new AccountLoginResponse
                {
                    IsLogin = false,
                    Username = null
                };
            }
            catch (Exception)
            {
                return new AccountLoginResponse
                {
                    IsLogin = false,
                    Username = null
                };
            }
        }
    }
}