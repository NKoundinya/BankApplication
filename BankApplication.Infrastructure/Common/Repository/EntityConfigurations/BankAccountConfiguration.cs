using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Repository
{
    class BankAccountEntityConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> bankAccountEntityConfiguration)
        {
            bankAccountEntityConfiguration.ToTable("BankAccount", BankContext.SCHEMA);
            bankAccountEntityConfiguration.HasKey(bankAccount => bankAccount.AccountId);
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.AccountId).ValueGeneratedNever();
            bankAccountEntityConfiguration.Property(bank => bank.User);
        }
    }
}