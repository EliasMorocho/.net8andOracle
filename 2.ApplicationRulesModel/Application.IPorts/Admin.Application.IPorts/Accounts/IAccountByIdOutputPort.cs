using Admin.Application.DTOs.Accounts;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountByIdOutputPort
    {
        ValueTask Handle(AccountByIdResponse response);
    }
}