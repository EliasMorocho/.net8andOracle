using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Infrastructure.IRepositories.Accounts;

namespace Admin.Application.UseCases.Accounts
{
    public class AccountRegisterInteractor : IAccountRegisterInputPort
    {
        private readonly IAccountRegisterRepository _accountRegisterRepository;
        private readonly IAccountRegisterOutputPort _accountRegisterOutputPort;

        public AccountRegisterInteractor(IAccountRegisterRepository accountRegisterRepository, IAccountRegisterOutputPort accountRegisterOutputPort)
        {
            _accountRegisterRepository = accountRegisterRepository;
            _accountRegisterOutputPort = accountRegisterOutputPort;
        }

        public async ValueTask Handle(AccountRegisterRequest request)
        {
            var response = await _accountRegisterRepository.Handle(request);
            await _accountRegisterOutputPort.Handle(response);
        }
    }
}