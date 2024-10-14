using Admin.Application.DTOs.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Presenters.Accounts
{
    public class AccountListPresenter : IAccountListPresenter
    {
        public AccountListResponse Content { get; private set; }

        public ValueTask Handle(AccountListResponse response)
        {
            Content = response;
            return ValueTask.CompletedTask;
        }
    }
}