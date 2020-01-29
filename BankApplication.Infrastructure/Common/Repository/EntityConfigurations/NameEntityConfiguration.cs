using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    public class NameEntityConfiguration : IEntityTypeConfiguration<Name>
    {
        public void Configure(EntityTypeBuilder<Name> nameEntityConfiguration)
        {
            nameEntityConfiguration.ToTable("Bank", BankContext.SCHEMA);
            
            nameEntityConfiguration.HasKey(Name => Name.Id);
            
            nameEntityConfiguration.Property(Name => Name.Id).ValueGeneratedNever().HasColumnName("id");
            nameEntityConfiguration.Property(Name => Name.FirstName).HasColumnName("firstname");
            nameEntityConfiguration.Property(Name => Name.MiddleName).HasColumnName("middlename");
            nameEntityConfiguration.Property(Name => Name.LastName).HasColumnName("lastname");
        }
    }
}