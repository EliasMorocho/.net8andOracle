using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountByIdInputPort
    {
        ValueTask Handle(AccountByIdRequest request);
    }
}