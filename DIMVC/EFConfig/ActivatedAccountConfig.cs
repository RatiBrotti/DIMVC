using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class ActivatedAccountConfig : IEntityTypeConfiguration<ActivatedAccount>
    {
        public void Configure(EntityTypeBuilder<ActivatedAccount> builder)
        {
            builder.ToTable("ActivatedAccount");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PasswordHash)
                .IsRequired()
                .HasMaxLength(70);

            builder.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.UserLevel)
                .IsRequired()
                .HasMaxLength(50).HasDefaultValue(1);

            builder.Property(e => e.AcaountStatus)
            .IsRequired(false).HasDefaultValue(true);

            builder.Property(e => e.DeactivationComment).HasMaxLength(100).IsRequired(false);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}
