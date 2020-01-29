using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> addressEntityConfiguration)
        {
            addressEntityConfiguration.ToTable("Address", BankContext.SCHEMA);

            addressEntityConfiguration.HasKey(Address => Address.Id);

            addressEntityConfiguration.Property(Address => Address.Id).ValueGeneratedNever();
            addressEntityConfiguration.Property(Address => Address.HouseNumber).HasColumnName("houseno");
            addressEntityConfiguration.Property(Address => Address.Street).HasColumnName("street");
            addressEntityConfiguration.Property(Address => Address.Colony).HasColumnName("colony");
            addressEntityConfiguration.Property(Address => Address.City).HasColumnName("city");
            addressEntityConfiguration.Property(Address => Address.State).HasColumnName("state");

            addressEntityConfiguration.OwnsOne(Address => Address.Country).Property(Country => Country.Id).HasColumnName("country");

            addressEntityConfiguration.Property(Address => Address.BankAccount.Id).HasColumnName("bankaccountid");
            
            addressEntityConfiguration.HasOne(Address => Address.BankAccount).WithOne().HasForeignKey("bankaccountid");
        }
    }
}