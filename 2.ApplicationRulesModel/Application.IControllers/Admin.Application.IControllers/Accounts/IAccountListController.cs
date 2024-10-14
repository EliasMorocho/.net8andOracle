using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IControllers.Accounts
{
    public interface IAccountListController
    {
        ValueTask<AccountListResponse> Handle(AccountListRequest request);
    }
}