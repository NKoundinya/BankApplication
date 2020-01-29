using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Bank : Entity
    {
        public string BankId { get; private set; }
        public string BankName { get; private set; }
        public Bank() { }
        public Bank(string bankId, string bankName)
        {
            Id = GetUniqueIdentifier();
            BankId = bankId;
            BankName = bankName;
        }
        // public void AddBankName(string bankName)
        // {
        //     BankName = bankName;
        // }
    }
}