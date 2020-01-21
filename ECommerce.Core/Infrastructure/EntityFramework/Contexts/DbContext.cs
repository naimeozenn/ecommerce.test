using ECommerce.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Core.Infrastructure.EntityFramework.Contexts
{
    public class ECommerceDbContext : DbContext
    {

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Address> Addresses;
        public DbSet<Basket> Baskets;
        public DbSet<BasketItem> BasketItems;
        public DbSet<Product> Product;
        public DbSet<User> User;      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            base.OnModelCreating(modelBuilder);
        }
    }
}
