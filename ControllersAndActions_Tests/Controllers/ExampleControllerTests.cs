using ControllersAndActions.Controllers;
using System;
using Xunit;

namespace ControllersAndActions_Tests.Controllers
{
    public class ExampleControllerTests
    {
        [Fact(DisplayName = "The ViewBag of the Index view has a string and DateTime")]
        public void CorrectViewbagTypesAreUsed()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var viewResult = exampleController.Index();

            // Assert
            Assert.IsType<string>(viewResult.ViewData["Message"]);
            Assert.Equal("Hello", viewResult.ViewData["Message"]);
            Assert.IsType<DateTime>(viewResult.ViewData["Date"]);
        }
    }
}
