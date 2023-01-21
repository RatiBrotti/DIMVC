using DIMVC.DbClasses;
using Microsoft.EntityFrameworkCore;
using System.Net;
using DIMVC.EFConfig;

namespace DIMVC.Context
{
    public partial class ShContext :DbContext
    {
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
            new ActivatedAccountConfig().Configure(modelBuilder.Entity<ActivatedAccount>());
            new AddressConfig().Configure(modelBuilder.Entity<Address>());
            new CategoryConfig().Configure(modelBuilder.Entity<Category>());
            new OrderConfig().Configure(modelBuilder.Entity<Order>());
            new OrderItemConfig().Configure(modelBuilder.Entity<OrderItem>());
            new ProductConfig().Configure(modelBuilder.Entity<Product>());
            new ShoppingBagConfig().Configure(modelBuilder.Entity<ShoppingBag>());
            new UnactivatedAccountsConfig().Configure(modelBuilder.Entity<UnactivatedAccount>());

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
