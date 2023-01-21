using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.AddressLine1)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.AddressLine2)
                .HasMaxLength(60);

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.CountryRegion)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.StateProvince)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(e => e.ActivatedAccount)
                .WithMany(e => e.Addresses)
                .HasForeignKey(e => e.AccountId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
