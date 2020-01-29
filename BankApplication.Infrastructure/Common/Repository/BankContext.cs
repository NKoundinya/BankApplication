using Microsoft.EntityFrameworkCore;

namespace BankApplication.Infrastructure.Repository
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options) { }

        public static string SCHEMA = "bankapplication";
        // DbSet<Bank> Banks { get; set; }
        // DbSet<BankAccount> BankAccounts { get; set; }
        // DbSet<User> Users { get; set; }
        // DbSet<Name> Name { get; set; }
        // DbSet<Address> Address { get; set; }
        // DbSet<Proof> Proofs { get; set; }        
        // DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BankAccountEntityConfiguration());
        }
    }
}