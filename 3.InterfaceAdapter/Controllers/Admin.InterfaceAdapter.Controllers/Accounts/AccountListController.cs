using Admin.Application.DTOs.Accounts;
using Admin.Application.IControllers.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public class AccountListController : IAccountListController
    {
        private readonly IAccountListInputPort _accountListInputPort;
        private readonly IAccountListPresenter _accountListPresenter;

        public AccountListController(IAccountListInputPort accountListInputPort, IAccountListPresenter accountListPresenter)
        {
            _accountListInputPort = accountListInputPort;
            _accountListPresenter = accountListPresenter;
        }

        public async ValueTask<AccountListResponse> Handle(AccountListRequest request)
        {
            await _accountListInputPort.Handle(request);
            return _accountListPresenter.Content;
        }
    }
}