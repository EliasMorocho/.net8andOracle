using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountLoginInputPort
    {
        ValueTask Handle(AccountLoginRequest request);
    }
}