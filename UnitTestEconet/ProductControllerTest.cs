using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EconetBlazor.Server.Controllers;
using Microsoft.EntityFrameworkCore;
using EconetBlazor.Server.Data;
using EconetBlazor.Client.Services.ProductService;
using NUnit.Framework;
using EconetBlazor.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace UnitTestEconet
{
    
        [TestClass]
        public class ProductControllerTest
    {
            private static readonly DbContextOptions<AppDbContext> dbContextOptions = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "ProjectControllerTest").Options;

            AppDbContext dbContext;
            ProductController productController;


            [OneTimeSetUp]

            public void Setup()
            {
                dbContext = new AppDbContext(dbContextOptions);
                dbContext.Database.EnsureCreated();

                SeedDatabase();

            
                productController = new ProductController(dbContext);
            }

            [Test, Order(1)]

            public void Test_CreateProducte()
            {
                // Arrange
                Product product = new()
                {
                    Id = 20,
                    Title = "Tshirt",
                    Description = "Green Tshirt",
                 ImageUrl = "sample.png",
                 Price = 20,
                 CategoryId = 3,
                 Visible = true,
                 Deleted = false,
                 Editing = false,
                 IsNew = true,
                 };


            // Act
            var result = productController.CreateProduct(product);


            // Assert
           
              Assert.AreEqual(product.Id, 3);
           
            }
  


            [OneTimeTearDown]

            public void CleanUp()
            {
                dbContext.Database.EnsureDeleted();
            }

            public void SeedDatabase()
            {
                var product = new List<Product>
            {
                new Product()
                {
                     Id = 16,
                 Title = "Jeans",
                 Description = "Green pants",
                 ImageUrl = "sample1.png",
                 Price = 25,
                 CategoryId = 3,
                 Visible = true,
                 Deleted = false,
                 Editing = false,
                 IsNew = true,
                 
        },
                new Product()
                {

                     Id = 17,
                 Title = "dress",
                 Description = "pink satin",
                 ImageUrl = "sample2.png",
                 Price = 25,
                 CategoryId = 3,
                 Visible = true,
                 Deleted = false,
                 Editing = false,
                 IsNew = true,
                },
                new Product
                {

                     Id = 15,
                 Title = "Jeans",
                 Description = "pants",
                 ImageUrl = "sample3.png",
                 Price = 25,
                 CategoryId = 4,
                 Visible = true,
                 Deleted = false,
                 Editing = false,
                 IsNew = true,
                },
                


            };
               
                dbContext.SaveChanges();

            }
        }
    }