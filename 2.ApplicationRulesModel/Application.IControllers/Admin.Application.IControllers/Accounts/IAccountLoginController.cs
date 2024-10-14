using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IControllers.Accounts
{
    public interface IAccountLoginController
    {
        ValueTask<AccountLoginResponse> Handle(AccountLoginRequest request);
    }
}