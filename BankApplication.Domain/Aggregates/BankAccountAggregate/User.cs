using System;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class User : Entity
    {
        private Guid _nameId;
        public Name Name { get; private set; }
        public string Role { get; private set; }
        public User() { }
        public User(
            Name name,
            string role)
        {
            Id = GetUniqueIdentifier();
            Name = name;
            _nameId = Name.Id;
            Role = role;
        }
    }
}