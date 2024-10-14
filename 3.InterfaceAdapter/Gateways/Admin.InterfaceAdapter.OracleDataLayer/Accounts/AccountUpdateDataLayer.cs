namespace Admin.InterfaceAdapter.OracleDataLayer.Accounts
{
    public class AccountUpdateDataLayer : IAccountUpdateRepository
    {
        private readonly AdminContext _context;

        public AccountUpdateDataLayer(AdminContext context)
        {
            _context = context;
        }

        public async ValueTask<MessageDTO> Handle(AccountUpdateRequest request)
        {
            try
            {
                var account = await _context.Accounts.FindAsync(Convert.ToInt32(request.Id));

                if (account == null)
                {
                    return new MessageDTO
                    {
                        Status = false,
                        Message = "Customer not found"
                    };
                }

                if (!string.IsNullOrEmpty(request.FullName))
                    account.FullName = request.FullName;

                if (!string.IsNullOrEmpty(request.Password))
                    account.PasswordHash = request.Password;

                if (!string.IsNullOrEmpty(request.Role))
                    account.Role = request.Role;

                account.IsActive = request.State;
                account.UpdatedAt = DateTime.Now;
                _context.Accounts.Update(account);
                await _context.SaveChangesAsync();

                return new MessageDTO
                {
                    Status = true,
                    Message = "Customer updated successfully"
                };
            }
            catch (Exception)
            {
                return new MessageDTO
                {
                    Status = false,
                    Message = "An error occurred while updating the customer"
                };
            }
        }
    }
}