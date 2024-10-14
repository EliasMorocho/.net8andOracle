using Admin.Application.DTOs.Accounts;
using Admin.Application.DTOs.Common;
using Admin.Application.IControllers.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public class AccountRegisterController : IAccountRegisterController
    {
        private readonly IAccountRegisterInputPort _accountRegisterInputPort;
        private readonly IAccountRegisterPresenter _accountRegisterPresenter;

        public AccountRegisterController(IAccountRegisterInputPort accountRegisterInputPort, IAccountRegisterPresenter accountRegisterPresenter)
        {
            _accountRegisterInputPort = accountRegisterInputPort;
            _accountRegisterPresenter = accountRegisterPresenter;
        }

        public async ValueTask<MessageDTO> Handle(AccountRegisterRequest request)
        {
            await _accountRegisterInputPort.Handle(request);
            return _accountRegisterPresenter.Context;
        }
    }
}