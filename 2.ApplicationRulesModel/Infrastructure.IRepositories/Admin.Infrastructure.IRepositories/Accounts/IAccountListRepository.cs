using Admin.Application.DTOs.Accounts;

namespace Admin.Infrastructure.IRepositories.Accounts
{
    public interface IAccountListRepository
    {
        ValueTask<AccountListResponse> Handle(AccountListRequest request);
    }
}