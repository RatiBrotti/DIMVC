using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class UnactivatedAccountsConfig : IEntityTypeConfiguration<UnactivatedAccount>
    {
        public void Configure(EntityTypeBuilder<UnactivatedAccount> builder)
        {
            builder.ToTable("UnactivatedAccount");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PasswordHash)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.ActivationToken)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
