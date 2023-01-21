using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.OrderId)
                .IsRequired();

            builder.Property(e => e.ProductId)
                .IsRequired();

            builder.Property(e => e.Quantity)
                .IsRequired()
                .HasDefaultValue(1);
        }
    }
}
