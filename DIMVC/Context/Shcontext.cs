using DIMVC.DbClasses;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DIMVC.EFConfig;

namespace DIMVC.Context
{
    public partial class ShContext :DbContext
    {
        public ShContext()
        {

        }
        public ShContext(DbContextOptions<ShContext> options) : base(options)
        {

        }
        public DbSet<ActivatedAccount> ActivatedAccounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingBag> ShoppingBags { get; set; }
        public DbSet<UnactivatedAccount> UnactivatedAccounts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.HasSequence("ContactIDSequence")
                .StartsAt(0)
                .IncrementsBy(10);

            modelBuilder.HasSequence("D").StartsAt(0);

            modelBuilder.HasSequence("val");

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
