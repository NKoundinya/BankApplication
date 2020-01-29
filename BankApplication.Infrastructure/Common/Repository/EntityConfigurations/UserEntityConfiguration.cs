using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> userEntityConfiguration)
        {
            userEntityConfiguration.ToTable("Bank", BankContext.SCHEMA);
            
            userEntityConfiguration.HasKey(User => User.Id);
            
            userEntityConfiguration.Property(User => User.Id).ValueGeneratedNever().HasColumnName("id");
            
            userEntityConfiguration.OwnsOne(User => User.Name).Property(Name => Name.Id).HasColumnName("name");

            userEntityConfiguration.Property(User => User.Role).HasColumnName("role");
        }
    }
}