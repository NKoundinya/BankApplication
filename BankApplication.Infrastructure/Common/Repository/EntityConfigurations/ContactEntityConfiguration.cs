using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    public class ContactEntityConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> contactEntityConfiguration)
        {
            contactEntityConfiguration.ToTable("Bank", BankContext.SCHEMA);

            contactEntityConfiguration.HasKey(Contact => Contact.Id);
            
            contactEntityConfiguration.Property(Contact => Contact.Id).ValueGeneratedNever().HasColumnName("id");
            contactEntityConfiguration.Property(Contact => Contact.PhoneNumber).HasColumnName("phonenumber");
            contactEntityConfiguration.Property(Contact => Contact.EmailId).HasColumnName("emailid");
            
            contactEntityConfiguration.Property(Contact => Contact.BankAccount.Id).HasColumnName("account");
            
            contactEntityConfiguration.HasOne(Contact => Contact.BankAccount).WithOne().HasForeignKey("accountid");
        }
    }
}