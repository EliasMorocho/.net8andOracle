using Admin.Application.DTOs.Accounts;

namespace Admin.Infrastructure.IRepositories.Accounts
{
    public interface IAccountLoginRepository
    {
        ValueTask<AccountLoginResponse> Handle(AccountLoginRequest request);
    }
}