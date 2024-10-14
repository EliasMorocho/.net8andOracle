using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountRegisterInputPort
    {
        ValueTask Handle(AccountRegisterRequest request);
    }
}