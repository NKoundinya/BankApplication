using System;
using System.Collections.Generic;
using BankApplication.Common.Mediator.Abstraction;
using BankApplication.Domain.Aggregates.BankAccountAggregate;
using BankApplication.Domain.Aggregates.Shared;
using BankApplication.Domain.Common.Enumerations;

namespace BankApplication.Application.Commands.Handler
{
    public class CreateBankAccountCommand : ICommand<bool>
    {
        public string AccountId { get; private set; }
        public User User { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public List<Proof> Proofs { get; private set; }
        public Gender Gender { get; private set; }
        public List<Contact> Contact { get; private set; }
        public List<Address> Address { get; private set; }
        public Amount TotalBalance { get; private set; }
        public Bank Bank { get; private set; }
        public CreateBankAccountCommand(
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
            Proofs = proofs;
            Gender = gender;
            Address = address;
            Bank = bank;
            Contact = contact;
            TotalBalance = totalBalance;
        }
    }
}