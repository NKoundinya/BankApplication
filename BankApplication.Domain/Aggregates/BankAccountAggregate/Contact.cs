using System;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Contact : Entity
    {
        public string EmailId { get; private set; }
        public Int64 PhoneNumber { get; private set; }
        public Contact() { }
        public Contact(
            string emailId,
            Int64 phoneNumber)
        {
            Id = GetUniqueIdentifier();
            EmailId = emailId;
            PhoneNumber = phoneNumber;
        }
    }
}