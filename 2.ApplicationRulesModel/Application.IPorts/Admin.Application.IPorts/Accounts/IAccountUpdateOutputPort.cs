using Admin.Application.DTOs.Common;

namespace Admin.Application.IPorts.Accounts
{
    public interface IAccountUpdateOutputPort
    {
        ValueTask Handle(MessageDTO response);
    }
}