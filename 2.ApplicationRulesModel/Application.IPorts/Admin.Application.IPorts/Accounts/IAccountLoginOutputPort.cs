using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountLoginOutputPort
    {
        ValueTask Handle(AccountLoginResponse response);
    }
}