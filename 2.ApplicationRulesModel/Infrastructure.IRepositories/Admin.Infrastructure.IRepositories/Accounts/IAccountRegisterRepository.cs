using Admin.Application.DTOs.Accounts;
using Admin.Application.DTOs.Common;

namespace Admin.Infrastructure.IRepositories.Accounts
{
    public interface IAccountRegisterRepository
    {
        ValueTask<MessageDTO> Handle(AccountRegisterRequest request);
    }
}