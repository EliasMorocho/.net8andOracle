using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Infrastructure.IRepositories.Accounts;

namespace Admin.Application.UseCases.Accounts
{
    public class AccountLoginInteractor : IAccountLoginInputPort
    {
        private readonly IAccountLoginRepository _accountLoginRepository;
        private readonly IAccountLoginOutputPort _accountLoginOutputPort;

        public AccountLoginInteractor(IAccountLoginRepository accountLoginRepository, IAccountLoginOutputPort accountLoginOutputPort)
        {
            _accountLoginRepository = accountLoginRepository;
            _accountLoginOutputPort = accountLoginOutputPort;
        }

        public async ValueTask Handle(AccountLoginRequest request)
        {
            var response = await _accountLoginRepository.Handle(request);
            await _accountLoginOutputPort.Handle(response);
        }
    }
}