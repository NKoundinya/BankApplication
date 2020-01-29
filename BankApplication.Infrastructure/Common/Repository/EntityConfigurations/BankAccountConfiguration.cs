using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    class BankAccountEntityConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> bankAccountEntityConfiguration)
        {
            bankAccountEntityConfiguration.ToTable("BankAccount", BankContext.SCHEMA);
            
            bankAccountEntityConfiguration.HasKey(bankAccount => bankAccount.AccountId);
            
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.AccountId).ValueGeneratedNever().HasColumnName("id");
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.DateOfBirth).HasColumnName("dateofbirth");
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.Gender).HasColumnName("gender");

            //Foreign Columns
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.User).HasColumnName("user");
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.Bank).HasColumnName("bankId");
            bankAccountEntityConfiguration.Property(bankAccount => bankAccount.Contact).HasColumnName("bankId");

            //Foreign Keys
            bankAccountEntityConfiguration.HasOne(bankAccount => bankAccount.User).WithOne().HasForeignKey("user");
            bankAccountEntityConfiguration.HasOne(bankAccount => bankAccount.Bank).WithOne().HasForeignKey("bankId");
            bankAccountEntityConfiguration.HasOne(bankAccount => bankAccount.Contact).WithMany().HasForeignKey("bankId");
            bankAccountEntityConfiguration.HasOne(bankAccount => bankAccount.Proofs).WithMany().HasForeignKey("bankId");
        }
    }
}