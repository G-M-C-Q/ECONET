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

            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId });

            modelBuilder.Entity<OrderItem>()
               .HasKey(oi => new { oi.OrderId, oi.ProductId });

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Knitwear",
                   Url = "knitwear"
               },
               new Category
               {
                   Id = 2,
                   Name = "Trousers",
                   Url = "trousers"
               },
               new Category
               {
                   Id = 3,
                   Name = "Dresses",
                   Url = "dresses"
               }
               );
            modelBuilder.Entity<Product>().HasData(
                        new Product
                        {
                            Id = 1,
                            Title = "Trousers",
                            Description = "blue and white striped relaxed fit trousers - super summery and slouched - size 10, could fit a small 12",
                            ImageUrl = "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1",
                            Price = 9.99m,
                            CategoryId = 2,
                            Featured = true
                        },
                        new Product
                        {
                            Id = 2,
                            Title = "Jumper",
                            Description = "If you want to look like a banana buy this jumper",
                            ImageUrl = "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg",
                            Price = 7.99m,
                            CategoryId = 1,
                            Featured = true
                        },
                        new Product
                        {
                            Id = 3,
                            Title = "Jeans",
                            Description = "denim straight leg trousers with logo loop on the back.",
                            ImageUrl = "https://i5.walmartimages.com/asr/fb7c02b1-6dbe-4c09-808b-03481f62e9f9.d5b7c792e2fe17292f76c76bfd8149b1.jpeg",
                            Price = 6.99m,
                            CategoryId = 2,
                            Featured = false
                        },
                         new Product
                         {
                             Id = 4,
                             Title = "Sun Dress",
                             Description = "Red Sundress",
                             ImageUrl = "https://xcdn.next.co.uk/COMMON/Items/Default/Default/ItemImages/AltItemShot/315x472/A57518s.jpg",
                             Price = 15.50m,
                             CategoryId = 3,
                             Featured = false
                         },
                        new Product
                        {
                            Id = 5,
                            Title = "Cropped Jumper",
                            Description = "Cream Cropped Jumper, High neckline",
                            ImageUrl = "https://media3.newlookassets.com/i/newlook/821129816/womens/clothing/knitwear/blue-vanilla-stone-cable-knit-roll-neck-crop-jumper.jpg?strip=true&qlt=80&w=720",
                            Price = 4.50m,
                            CategoryId = 1,
                            Featured = false
                        },
                         new Product
                         {
                             Id = 6,
                             Title = "Pleather Pants",
                             Description = "Black faux leather pant",
                             ImageUrl = "https://th.bing.com/th/id/R.bc70a7d3ed0d142eab927ca61b63916b?rik=rticQCYYDgN9wg&pid=ImgRaw&r=0",
                             Price = 9.99m,
                             CategoryId = 2,
                             Featured = true
                         },
                        new Product
                        {
                            Id = 7,
                            Title = "Midi Dress",
                            Description = "Midnight Blue Satin Midi dress",
                            ImageUrl = "https://th.bing.com/th/id/OIP.HT8GDy8mfo8AcGa5BSS4YAHaLz?pid=ImgDet&rs=1",
                            Price = 12.00m,
                            CategoryId = 3,
                            Featured = true
                        },
                         new Product
                         {
                             Id = 8,
                             Title = "LBD",
                             Description = "Little black dress with sequin detail",
                             ImageUrl = "https://img.promgirl.com/_img/PGPRODUCTS/2270536/1000/black-dress-SOP-D17733LCS-b.jpg",
                             Price = 9.99m,
                             CategoryId = 3,
                             Featured = false
                         },
                        new Product
                        {
                            Id = 9,
                            Title = "Turtle neck",
                            Description = "Pink Turtleneck Jumper",
                            ImageUrl = "https://tommy-europe.scene7.com/is/image/TommyEurope/KG0KG06895_TZO_main?$main$",
                            Price = 6.00m,
                            CategoryId = 1,
                            Featured = true
                        }
                    );
            }
        //Tables in database 
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<CartItem> CartItems { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderItem> OrderItems { get; set; }
    }
    }