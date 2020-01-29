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
        private List<Proof> _proofs;
        public IReadOnlyList<Proof> Proofs => _proofs;
        public Gender Gender { get; private set; }
        private int _genderId;
        private List<Contact> _contact;
        public IReadOnlyCollection<Contact> Contact => _contact;
        private List<Address> _address;
        public IReadOnlyList<Address> Address => _address;
        public Amount TotalBalance { get; private set; }
        public Bank Bank { get; private set; }
        public BankAccount() { }
        public BankAccount(
            string accountId,
            User user,
            DateTime dateOfBirth,
            List<Proof> proofs,
            Gender gender,
            List<Address> address,
            Bank bank,
            List<Contact> contact,
            Amount totalBalance)
        {
            AccountId = accountId;
            User = user;
            DateOfBirth = dateOfBirth;
            _proofs = proofs;
            _genderId = gender.Id;
            _address = address;
            Bank = bank;
            _contact = contact;
            TotalBalance = totalBalance;
        }
    }
}