using System;
using System.Collections.Generic;
using BankApplication.Domain.Common.Enumerations;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Address : Entity
    {
        public string HouseNumber { get; private set; }
        public string Street { get; private set; }
        public string Colony { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public Country Country { get; private set; }
        private int _countryId;
        public BankAccount BankAccount { get; private set; }
        private string _bankAccountId;
        public Address() { }
        public Address(
            string houseNumber,
            string street,
            string colony,
            string city,
            string state,
            Country country,
            string bankAccountId)
        {
            Id = GetUniqueIdentifier();
            HouseNumber = houseNumber;
            Colony = colony;
            City = city;
            State = state;
            _countryId = country.Id;
            _bankAccountId = bankAccountId;
        }
    }
}