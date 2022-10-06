using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructuree.Data
{
    public class MarketContext : DbContext

    {

        public MarketContext(DbContextOptions<MarketContext> options) : base(options)
        {
        }
        //properties DBSet 
        //access items and use methods in DB context to find an entity with ID
        //items tabled generated in database
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemBrand> ItemBrands { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }

   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}