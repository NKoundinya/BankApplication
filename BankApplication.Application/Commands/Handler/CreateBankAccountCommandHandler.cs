using System.Threading;
using System.Threading.Tasks;
using BankApplication.Common.Mediator.Abstraction;
using BankApplication.Domain.Aggregates.BankAccountAggregate.Contracts;
using BankApplication.Domain.Common.SeedWork;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Application.Commands.Handler
{
    public class CreateBankAccountCommandHandler : CommandHandler<CreateBankAccountCommand, bool>
    {
        private readonly IBankAccountRepository _bankAccountRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateBankAccountCommandHandler(IBankAccountRepository bankAccountRepository, IUnitOfWork unitOfWork)
        {
            _bankAccountRepository = bankAccountRepository;
            _unitOfWork = unitOfWork;
        }
        public override async Task<bool> HandleCommandAsync(CreateBankAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var account = new BankAccount();
                await _bankAccountRepository.AddAsync(account);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}