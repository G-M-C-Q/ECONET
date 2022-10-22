using Microsoft.EntityFrameworkCore;

namespace EconetBlazor.Server.Data
{
    public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = 1,
                            Title = "Trousers",
                            Description = "blue and white striped relaxed fit trousers - super summery and slouched - size 10, could fit a small 12",
                            ImageUrl = "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1",
                            Price = 9.99m
                        },
                        new Product
                        {
                            Id = 2,
                            Title = "Jumper",
                            Description = "If you want to look like a banana buy this jumper",
                            ImageUrl = "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg",
                            Price = 7.99m
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "Jeans",
                            Description = "denim straight leg trousers with logo loop on the back.",
                            ImageUrl = "https://en.wikipedia.org/wiki/Jeans#/media/File:Jeans.jpg",
                            Price = 6.99m
                        }
                    );
            }

            public DbSet<Product> Products { get; set; }
        }
    }