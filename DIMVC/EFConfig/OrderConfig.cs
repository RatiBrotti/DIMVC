using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DIMVC.DbClasses;
namespace DIMVC.EFConfig
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.ShipDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())").IsRequired(false);

            builder.Property(e => e.PaymentStatus)
                .HasDefaultValue(false);

            builder.Property(e => e.OrderNumber)
                .ValueGeneratedOnAdd()
                .HasDefaultValue(1000)
                .IsRequired();

            builder.Property(e => e.ShipToAddressId)
                .IsRequired();

            builder.Property(e => e.BillToAddressId)
                .IsRequired(false);

            builder.Property(e => e.ShipMethod)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.Total)
                .IsRequired()
                .HasColumnType("decimal(10, 2)");

            builder.Property(e => e.Comment)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.HasOne(e => e.Address)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.ShipToAddressId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Orders_ShipToAddressId_Addresses");

            builder.HasOne(e => e.Address)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.BillToAddressId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Orders_BillToAddressId_Addresses");

            builder.HasOne(e => e.ActivatedAccount)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.AccountId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(e => e.OrderItems)
                .WithOne(e => e.Order)
                .HasForeignKey(e => e.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
