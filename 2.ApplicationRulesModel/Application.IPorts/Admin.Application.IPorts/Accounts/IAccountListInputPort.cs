using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountListInputPort
    {
        ValueTask Handle(AccountListRequest request);
    }
}