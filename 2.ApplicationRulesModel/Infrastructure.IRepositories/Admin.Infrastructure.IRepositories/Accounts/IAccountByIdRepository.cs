using Admin.Application.DTOs.Accounts;

namespace Admin.Infrastructure.IRepositories.Accounts
{
    public interface IAccountByIdRepository
    {
        ValueTask<AccountByIdResponse> Handle(AccountByIdRequest request);
    }
}