using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Infrastructure.IRepositories.Accounts;

namespace Admin.Application.UseCases.Accounts
{
    public class AccountUpdateInteractor : IAccountUpdateInputPort
    {
        private readonly IAccountUpdateRepository _accountUpdateRepository;
        private readonly IAccountUpdateOutputPort _accountUpdateOutputPort;

        public AccountUpdateInteractor(IAccountUpdateRepository accountUpdateRepository, IAccountUpdateOutputPort accountUpdateOutputPort)
        {
            _accountUpdateRepository = accountUpdateRepository;
            _accountUpdateOutputPort = accountUpdateOutputPort;
        }

        public async ValueTask Handle(AccountUpdateRequest request)
        {
            var response = await _accountUpdateRepository.Handle(request);
            await _accountUpdateOutputPort.Handle(response);
        }
    }
}