using Beispiel.Sportsstore.Controllers;
using Beispiel.Sportsstore.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Beispiel.Sportsstore.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void CanUseRepository()
        {
            // Arrange
            Product[] products = new Product[]
            {
                new Product() { ProductID = 1, Name = "P1" },
                new Product() { ProductID = 2, Name = "P2" }
            };
            Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            mock.SetupGet(m => m.Products).Returns(products.AsQueryable());

            HomeController controller = new HomeController(mock.Object);

            // Act
            var result = (controller.Index() as ViewResult)
                            .ViewData
                            .Model as IEnumerable<Product>;
            Product[] prodArray = result.ToArray();

            // Assert
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P1", prodArray[0].Name);
            Assert.Equal("P2", prodArray[1].Name);

        }
    }
}
