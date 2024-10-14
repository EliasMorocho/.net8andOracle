using Admin.Application.DTOs.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Presenters.Accounts
{
    public class AccountLoginPresenter : IAccountLoginPresenter
    {
        public AccountLoginResponse Content { get; private set; }

        public ValueTask Handle(AccountLoginResponse response)
        {
            Content = response;
            return ValueTask.CompletedTask;
        }
    }
}