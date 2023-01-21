using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {


            builder.ToTable("Product");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ProductName)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.Property(e => e.ProductNumber)
                 .IsRequired(false)
                 .HasMaxLength(50);

            builder.Property(e => e.Color)
                 .IsRequired(false)
                 .HasMaxLength(15);

            builder.Property(e => e.ProductPrice)
                 .IsRequired()
                 .HasColumnType("decimal(10, 2)");

            builder.Property(e => e.ShippingPrice)
                 .IsRequired()
                 .HasColumnType("decimal(10,2)")
                 .HasDefaultValue(0);

            builder.Property(e => e.ShippingDimensions)
                 .IsRequired(false)
                 .HasMaxLength(40);

            builder.Property(e => e.ShippingWeight)
                 .HasColumnType("decimal(6,1)")
                 .IsRequired(false);

            builder.Property(e => e.Describtion)
                 .IsRequired(false)
                 .HasMaxLength(100);


            builder.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.PhotoFileName)
                .HasMaxLength(100);

            builder.HasOne(e => e.ActivatedAccount)
                .WithMany(a => a.Products)
                .HasForeignKey(e => e.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);




        }
    }
}
