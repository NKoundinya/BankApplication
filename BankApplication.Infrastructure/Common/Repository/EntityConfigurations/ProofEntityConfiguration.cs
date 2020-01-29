using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.EntityConfigurations
{
    public class ProofEntityConfiguration : IEntityTypeConfiguration<Proof>
    {
        public void Configure(EntityTypeBuilder<Proof> proofEntityConfiguration)
        {
            proofEntityConfiguration.ToTable("Bank", BankContext.SCHEMA);

            proofEntityConfiguration.HasKey(Proof => Proof.Id);
            
            proofEntityConfiguration.Property(Proof => Proof.Id).ValueGeneratedNever().HasColumnName("id");
            proofEntityConfiguration.Property(Proof => Proof.Type).HasColumnName("type");
            proofEntityConfiguration.Property(Proof => Proof.ProofId).HasColumnName("proofIdNumber");
            
            proofEntityConfiguration.Property(Proof => Proof.BankAccount.Id).HasColumnName("accountProof");

            proofEntityConfiguration.HasOne(Proof => Proof.BankAccount).WithOne().HasForeignKey("acountProof");
        }
    }
}