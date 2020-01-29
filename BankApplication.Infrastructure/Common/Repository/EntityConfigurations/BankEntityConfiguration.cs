using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    public class BankEntityConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> bankEntityConfiguration)
        {
            bankEntityConfiguration.ToTable("Bank", BankContext.SCHEMA);
            bankEntityConfiguration.HasKey(bank => bank.BankId);
            bankEntityConfiguration.Property(bank => bank.BankId).ValueGeneratedNever().HasColumnName("id");
            bankEntityConfiguration.Property(bank => bank.BankName).HasColumnName("bankname");
        }
    }
}