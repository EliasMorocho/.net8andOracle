using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;

namespace Admin.Application.IPresenters.Accounts
{
    public interface IAccountLoginPresenter : IAccountLoginOutputPort
    {
        AccountLoginResponse Content { get; }
    }
}