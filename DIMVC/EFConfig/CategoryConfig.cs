using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using DIMVC.DbClasses;

namespace DIMVC.EFConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            builder.ToTable("Category");

            builder.HasIndex(e => e.CategoryName)
                        .IsUnique();

            builder.Property(e => e.Id);

            builder.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

            builder.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.ParentCategoryId)
                    .IsRequired(false);

            builder.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.ChildCategories)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
