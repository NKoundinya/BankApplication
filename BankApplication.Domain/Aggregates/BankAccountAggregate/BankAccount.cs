using System;
using System.Collections.Generic;
using BankApplication.Domain.Aggregates.Shared;
using BankApplication.Domain.Common.SeedWork;
using BankApplication.Domain.Common.Enumerations;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class BankAccount : Entity, IAggregateRoot
    {
        public string AccountId { get; private set; }
        public User User { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public List<Proof> Proofs { get; private set; }
        public Gender Gender { get; private set; }
        private int _genderId;
        public Contact contact { get; private set; }
        private List<Address> _address;
        public IReadOnlyList<Address> Address => _address;
        public Amount TotalBalance { get; private set; }
        public Bank Bank { get; private set; }
        public string _bankId;
        public BankAccount() { }
        public BankAccount(
            string id,
            User user,
            DateTime dateOfBirth,
            List<Proof> proofs,
            Gender gender,
            List<Address> address,
            string bankId,
            Amount totalBalance)
        {
            AccountId = id;
            DateOfBirth = dateOfBirth;
            Proofs = proofs;
            _genderId = gender.Id;
            _address = address;
            _bankId = bankId;
            TotalBalance = totalBalance;
        }
    }
}