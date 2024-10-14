using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountUpdateInputPort
    {
        ValueTask Handle(AccountUpdateRequest request);
    }
}