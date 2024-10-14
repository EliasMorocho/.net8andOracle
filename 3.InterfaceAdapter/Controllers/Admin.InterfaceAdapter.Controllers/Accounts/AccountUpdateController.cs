using Admin.Application.DTOs.Accounts;
using Admin.Application.DTOs.Common;
using Admin.Application.IControllers.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public class AccountUpdateController : IAccountUpdateController
    {
        private readonly IAccountUpdateInputPort _accountUpdateInputPort;
        private readonly IAccountUpdatePresenter _accountUpdatePresenter;

        public AccountUpdateController(IAccountUpdateInputPort accountUpdateInputPort, IAccountUpdatePresenter accountUpdatePresenter)
        {
            _accountUpdateInputPort = accountUpdateInputPort;
            _accountUpdatePresenter = accountUpdatePresenter;
        }

        public async ValueTask<MessageDTO> Handle(AccountUpdateRequest request)
        {
            await _accountUpdateInputPort.Handle(request);
            return _accountUpdatePresenter.Context;
        }
    }
}