using Admin.Application.DTOs.Common;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Presenters.Accounts
{
    public class AccountRegisterPresenter : IAccountRegisterPresenter
    {
        public MessageDTO Context { get; private set; }

        public ValueTask Handle(MessageDTO response)
        {
            Context = response;
            return ValueTask.CompletedTask;
        }
    }
}