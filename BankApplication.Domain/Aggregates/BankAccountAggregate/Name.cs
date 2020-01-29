using System;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Name : Entity
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public Name(
            string firstName,
            string middleName,
            string lastName)
        {
            Id = GetUniqueIdentifier();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }
}