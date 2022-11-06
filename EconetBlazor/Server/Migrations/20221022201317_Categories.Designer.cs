﻿// <auto-generated />
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
    [Migration("20221022201317_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                            ImageUrl = "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1",
                            Price = 9.99m,
                            Title = "Trousers"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "If you want to look like a banana buy this jumper",
                            ImageUrl = "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg",
                            Price = 7.99m,
                            Title = "Jumper"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "denim straight leg trousers with logo loop on the back.",
                            ImageUrl = "https://en.wikipedia.org/wiki/Jeans#/media/File:Jeans.jpg",
                            Price = 6.99m,
                            Title = "Jeans"
                        });
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
