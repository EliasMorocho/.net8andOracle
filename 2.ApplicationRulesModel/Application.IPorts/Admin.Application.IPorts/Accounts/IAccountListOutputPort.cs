using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountListOutputPort
    {
        ValueTask Handle(AccountListResponse response);
    }
}