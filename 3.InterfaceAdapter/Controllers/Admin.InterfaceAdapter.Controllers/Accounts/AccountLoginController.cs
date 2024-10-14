using Admin.Application.DTOs.Accounts;
using Admin.Application.IControllers.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Application.IPresenters.Accounts;

namespace Admin.InterfaceAdapter.Controllers.Accounts
{
    public class AccountLoginController : IAccountLoginController
    {
        private readonly IAccountLoginInputPort _accountLoginInputPot;
        private readonly IAccountLoginPresenter _accountLoginPresenter;

        public AccountLoginController(IAccountLoginInputPort accountLoginInputPot, IAccountLoginPresenter accountLoginPresenter)
        {
            _accountLoginInputPot = accountLoginInputPot;
            _accountLoginPresenter = accountLoginPresenter;
        }

        public async ValueTask<AccountLoginResponse> Handle(AccountLoginRequest request)
        {
            await _accountLoginInputPot.Handle(request);
            return _accountLoginPresenter.Content;
        }
    }
}