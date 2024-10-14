using Admin.Application.DTOs.Common;
using Admin.Application.IPorts.Accounts;

namespace Admin.Application.IPresenters.Accounts
{
    public interface IAccountUpdatePresenter : IAccountUpdateOutputPort
    {
        MessageDTO Context { get; }
    }
}