using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Bank : IAggregateRoot
    {
        public string BankId { get; private set; }
        public string BankName { get; private set; }
        public Bank() { }
        public Bank(string bankId, string bankName)
        {
            BankId = bankId;
            BankName = bankName;
        }
        // public void AddBankName(string bankName)
        // {
        //     BankName = bankName;
        // }
    }
}