﻿// <auto-generated />
using System;
using EconetBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EconetBlazor.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221119233306_CartDb")]
    partial class CartDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EconetBlazor.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("EconetBlazor.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Knitwear",
                            Url = "knitwear"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Trousers",
                            Url = "trousers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dresses",
                            Url = "dresses"
                        });
                });

            modelBuilder.Entity("EconetBlazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "blue and white striped relaxed fit trousers - super summery and slouched - size 10, could fit a small 12",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1",
                            Price = 9.99m,
                            Title = "Trousers"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "If you want to look like a banana buy this jumper",
                            Featured = true,
                            ImageUrl = "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg",
                            Price = 7.99m,
                            Title = "Jumper"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "denim straight leg trousers with logo loop on the back.",
                            Featured = false,
                            ImageUrl = "https://i5.walmartimages.com/asr/fb7c02b1-6dbe-4c09-808b-03481f62e9f9.d5b7c792e2fe17292f76c76bfd8149b1.jpeg",
                            Price = 6.99m,
                            Title = "Jeans"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Red Sundress",
                            Featured = false,
                            ImageUrl = "https://xcdn.next.co.uk/COMMON/Items/Default/Default/ItemImages/AltItemShot/315x472/A57518s.jpg",
                            Price = 15.50m,
                            Title = "Sun Dress"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Cream Cropped Jumper, High neckline",
                            Featured = false,
                            ImageUrl = "https://media3.newlookassets.com/i/newlook/821129816/womens/clothing/knitwear/blue-vanilla-stone-cable-knit-roll-neck-crop-jumper.jpg?strip=true&qlt=80&w=720",
                            Price = 4.50m,
                            Title = "Cropped Jumper"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Black faux leather pant",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/R.bc70a7d3ed0d142eab927ca61b63916b?rik=rticQCYYDgN9wg&pid=ImgRaw&r=0",
                            Price = 9.99m,
                            Title = "Pleather Pants"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Midnight Blue Satin Midi dress",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/OIP.HT8GDy8mfo8AcGa5BSS4YAHaLz?pid=ImgDet&rs=1",
                            Price = 12.00m,
                            Title = "Midi Dress"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Little black dress with sequin detail",
                            Featured = false,
                            ImageUrl = "https://img.promgirl.com/_img/PGPRODUCTS/2270536/1000/black-dress-SOP-D17733LCS-b.jpg",
                            Price = 9.99m,
                            Title = "LBD"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Pink Turtleneck Jumper",
                            Featured = true,
                            ImageUrl = "https://tommy-europe.scene7.com/is/image/TommyEurope/KG0KG06895_TZO_main?$main$",
                            Price = 6.00m,
                            Title = "Turtle neck"
                        });
                });

            modelBuilder.Entity("EconetBlazor.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EconetBlazor.Shared.Product", b =>
                {
                    b.HasOne("EconetBlazor.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}