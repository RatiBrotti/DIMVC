using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class ShoppingBagConfig : IEntityTypeConfiguration<ShoppingBag>
    {
        public void Configure(EntityTypeBuilder<ShoppingBag> builder)
        {
            builder.ToTable("ShoppingBag");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Quantity)
                .IsRequired();

            builder.HasOne(e => e.ActivatedAccount)
                .WithMany(a => a.ShoppingBags)
                .HasForeignKey(e => e.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Product)
                .WithMany(p => p.ShoppingBags)
                .HasForeignKey(e => e.ProductID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
