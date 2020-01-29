using BankApplication.Domain.Common.SeedWork;
using BankApplication.Domain.Aggregates.Shared;

namespace BankApplication.Domain.Aggregates.TransactionAggregate
{
    public class Transactions : Entity
    {
        public string TransactionId { get; private set; }
        public Amount Deposit { get; private set; }
        public Amount Transact { get; private set; }
        public Transactions() { }
        public Transactions(
            Amount deposit,
            Amount transact
        )
        {
            Id = GetUniqueIdentifier();
            Deposit = deposit;
            Transact = transact;
        }
    }
}