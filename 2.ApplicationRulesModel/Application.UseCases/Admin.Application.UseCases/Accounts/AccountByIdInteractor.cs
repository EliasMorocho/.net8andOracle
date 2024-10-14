using Admin.Application.DTOs.Accounts;
using Admin.Application.IPorts.Accounts;
using Admin.Infrastructure.IRepositories.Accounts;

namespace Admin.Application.UseCases.Accounts
{
    public class AccountByIdInteractor : IAccountByIdInputPort
    {
        private readonly IAccountByIdRepository _accountByIdRepository;
        private readonly IAccountByIdOutputPort _accountByIdOutputPort;

        public AccountByIdInteractor(IAccountByIdRepository accountByIdRepository, IAccountByIdOutputPort accountByIdOutputPort)
        {
            _accountByIdRepository = accountByIdRepository;
            _accountByIdOutputPort = accountByIdOutputPort;
        }

        public async ValueTask Handle(AccountByIdRequest request)
        {
            var response = await _accountByIdRepository.Handle(request);
            await _accountByIdOutputPort.Handle(response);
        }
    }
}