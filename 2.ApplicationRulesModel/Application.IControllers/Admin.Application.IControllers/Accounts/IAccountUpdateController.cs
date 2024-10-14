using Admin.Application.DTOs.Accounts;
using Admin.Application.DTOs.Common;

namespace Admin.Application.IControllers.Accounts
{
    public interface IAccountUpdateController
    {
        ValueTask<MessageDTO> Handle(AccountUpdateRequest request);
    }
}