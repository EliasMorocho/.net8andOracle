using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Infrastructure.IRepositories.Accounts;

namespace Admin.Application.UseCases.Accounts
{
    public class AccountListInteractor : IAccountListInputPort
    {
        private IAccountListRepository _accountListRepository;
        private IAccountListOutputPort _accountListOutputPort;

        public AccountListInteractor(IAccountListRepository accountListRepository, IAccountListOutputPort accountListOutputPort)
        {
            _accountListRepository = accountListRepository;
            _accountListOutputPort = accountListOutputPort;
        }

        public async ValueTask Handle(AccountListRequest request)
        {
            var response = await _accountListRepository.Handle(request);
            await _accountListOutputPort.Handle(response);
        }
    }
}