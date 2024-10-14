using Admin.Application.DTOs.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Presenters.Accounts
{
    public class AccountByIdPresenter : IAccountByIdPresenter
    {
        public AccountByIdResponse Context { get; private set; }

        public ValueTask Handle(AccountByIdResponse response)
        {
            Context = response;
            return ValueTask.CompletedTask;
        }
    }
}