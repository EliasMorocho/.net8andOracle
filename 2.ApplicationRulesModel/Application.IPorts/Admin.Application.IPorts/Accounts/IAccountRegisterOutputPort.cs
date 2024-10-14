using Admin.Application.DTOs.Common;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountRegisterOutputPort
    {
        ValueTask Handle(MessageDTO response);
    }
}