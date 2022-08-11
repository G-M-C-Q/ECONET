using ECONET.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECONET.Data
{
    public class MarketContext :DbContext

    {

        public MarketContext(DbContextOptions<MarketContext> options) : base(options)
        {
        }
            //properties DBSet 
            //access items and use methods in DB context to find an entity with ID
            public DbSet<Item> Items { get; set; }
        }


    }
