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
    [Migration("20221204171148_Products")]
    partial class Products
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EconetBlazor.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

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

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Knitwear",
                            Url = "knitwear",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Trousers",
                            Url = "trousers",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            Deleted = false,
                            Name = "Dresses",
                            Url = "dresses",
                            Visible = true
                        });
                });

            modelBuilder.Entity("EconetBlazor.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EconetBlazor.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EconetBlazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "blue and white striped relaxed fit trousers - super summery and slouched - size 10, could fit a small 12",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1",
                            Price = 9.99m,
                            Title = "Trousers",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "If you want to look like a banana buy this jumper",
                            Featured = true,
                            ImageUrl = "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg",
                            Price = 7.99m,
                            Title = "Jumper",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "denim straight leg trousers with logo loop on the back.",
                            Featured = false,
                            ImageUrl = "https://i5.walmartimages.com/asr/fb7c02b1-6dbe-4c09-808b-03481f62e9f9.d5b7c792e2fe17292f76c76bfd8149b1.jpeg",
                            Price = 6.99m,
                            Title = "Jeans",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Red Sundress",
                            Featured = false,
                            ImageUrl = "https://xcdn.next.co.uk/COMMON/Items/Default/Default/ItemImages/AltItemShot/315x472/A57518s.jpg",
                            Price = 15.50m,
                            Title = "Sun Dress",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Cream Cropped Jumper, High neckline",
                            Featured = false,
                            ImageUrl = "https://media3.newlookassets.com/i/newlook/821129816/womens/clothing/knitwear/blue-vanilla-stone-cable-knit-roll-neck-crop-jumper.jpg?strip=true&qlt=80&w=720",
                            Price = 4.50m,
                            Title = "Cropped Jumper",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Black faux leather pant",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/R.bc70a7d3ed0d142eab927ca61b63916b?rik=rticQCYYDgN9wg&pid=ImgRaw&r=0",
                            Price = 9.99m,
                            Title = "Pleather Pants",
                            Visible = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Midnight Blue Satin Midi dress",
                            Featured = true,
                            ImageUrl = "https://th.bing.com/th/id/OIP.HT8GDy8mfo8AcGa5BSS4YAHaLz?pid=ImgDet&rs=1",
                            Price = 12.00m,
                            Title = "Midi Dress",
                            Visible = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Deleted = false,
                            Description = "Little black dress with sequin detail",
                            Featured = false,
                            ImageUrl = "https://img.promgirl.com/_img/PGPRODUCTS/2270536/1000/black-dress-SOP-D17733LCS-b.jpg",
                            Price = 9.99m,
                            Title = "LBD",
                            Visible = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Pink Turtleneck Jumper",
                            Featured = true,
                            ImageUrl = "https://tommy-europe.scene7.com/is/image/TommyEurope/KG0KG06895_TZO_main?$main$",
                            Price = 6.00m,
                            Title = "Turtle neck",
                            Visible = true
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

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EconetBlazor.Shared.Address", b =>
                {
                    b.HasOne("EconetBlazor.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("EconetBlazor.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EconetBlazor.Shared.OrderItem", b =>
                {
                    b.HasOne("EconetBlazor.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EconetBlazor.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
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

            modelBuilder.Entity("EconetBlazor.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EconetBlazor.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
