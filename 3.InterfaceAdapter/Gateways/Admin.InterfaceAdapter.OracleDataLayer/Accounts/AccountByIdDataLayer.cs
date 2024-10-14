namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public class AccountByIdDataLayer : IAccountByIdRepository
    {
        private readonly AdminContext _context;

        public AccountByIdDataLayer(AdminContext context)
        {
            _context = context;
        }

        public async ValueTask<AccountByIdResponse> Handle(AccountByIdRequest request)
        {
            try
            {
                var accountId = Convert.ToInt32(request.Id);
                var response = await _context.Accounts.FindAsync(accountId);

                if (response != null)
                {
                    return new AccountByIdResponse
                    {
                        Account = MapResponseToAccountDTO(response)
                    };
                }
            }
            catch (Exception ex)
            {
            }

            return new AccountByIdResponse
            {
                Account = null
            };
        }

        private AccountDTO MapResponseToAccountDTO(Account account)
        {
            return new AccountDTO
            {
                Id = account.Id.ToString(),
                FullName = account.FullName,
                Email = account.Email,
                Role = account.Role,
                Password = account.PasswordHash,
                State = account.IsActive == 1 ? true : false,
            };
        }
    }
}