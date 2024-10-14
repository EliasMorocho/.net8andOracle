namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public class AccountListDataLayer : IAccountListRepository
    {
        private readonly AdminContext _context;

        public AccountListDataLayer(AdminContext context)
        {
            _context = context;
        }

        public async ValueTask<AccountListResponse> Handle(AccountListRequest request)
        {
            var response = await _context.Accounts.ToListAsync();
            var accounts = ParseItemsToCustomers(response);

            return new AccountListResponse
            {
                Token = null,
                Accounts = accounts
            };
        }

        private List<AccountDTO> ParseItemsToCustomers(List<Account> accounts)
        {
            return accounts.Select(item => new AccountDTO
            {
                Id = item.Id.ToString(),
                FullName = item.FullName,
                Email = item.Email,
                Role = item.Role,
                Password = item.PasswordHash,
                State = item.IsActive == 1 ? true : false
            }).ToList();
        }
    }
}