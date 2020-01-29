using System;
using BankApplication.Domain.Common.SeedWork;
using BankApplication.Domain.Aggregates.Common;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate
{
    public class Proof : Entity
    {
        public ProofType Type { get; private set; }
        public ProofType ProofId { get; private set; }
        public BankAccount BankAccount { get; private set; }
        public Proof() { }
        public Proof(
            ProofType type,
            ProofType proofId,
            BankAccount bankAccount)
        {
            Id = GetUniqueIdentifier();
            Type = type;
            ProofId = proofId;
            BankAccount = bankAccount;
        }
    }
}