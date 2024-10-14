using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IControllers.Accounts
{
    public interface IAccountByIdController
    {
        ValueTask<AccountByIdResponse> Handle(AccountByIdRequest request);
    }
}