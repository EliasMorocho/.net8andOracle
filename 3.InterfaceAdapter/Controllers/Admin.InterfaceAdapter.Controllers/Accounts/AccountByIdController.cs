using Admin.Application.DTOs.Accounts;
using Admin.Application.IControllers.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public class AccountByIdController : IAccountByIdController
    {
        private readonly IAccountByIdInputPort _accountByIdInputPort;
        private readonly IAccountByIdPresenter _accountByIdPresenter;

        public AccountByIdController(IAccountByIdInputPort accountByIdInputPort, IAccountByIdPresenter accountByIdPresenter)
        {
            _accountByIdInputPort = accountByIdInputPort;
            _accountByIdPresenter = accountByIdPresenter;
        }

        public async ValueTask<AccountByIdResponse> Handle(AccountByIdRequest request)
        {
            await _accountByIdInputPort.Handle(request);
            return _accountByIdPresenter.Context;
        }
    }
}