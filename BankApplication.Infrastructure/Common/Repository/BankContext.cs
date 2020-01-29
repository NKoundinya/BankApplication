using Microsoft.EntityFrameworkCore;
using BankApplication.Infrastructure.Common.Repository.EntityConfigurations;
using BankApplication.Domain.Aggregates.BankAccountAggregate;
using BankApplication.Domain.Aggregates.TransactionAggregate;

namespace BankApplication.Infrastructure.Common.Repository
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options) { }

        public static string SCHEMA = "bankapplication";
        DbSet<Bank> Banks { get; set; }
        DbSet<BankAccount> BankAccounts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Name> Name { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<Proof> Proofs { get; set; }        
        DbSet<Transactions> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BankEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ContactEntityConfiguration());
            modelBuilder.ApplyConfiguration(new NameEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProofEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }
    }
}