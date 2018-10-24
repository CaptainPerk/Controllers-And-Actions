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

        [Fact(DisplayName = "When the Redirect action is called the user is redirected to the Home/Index action")]
        public void Redirection()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var redirectResult = exampleController.Redirect();

            // Assert
            Assert.False(redirectResult.Permanent);
            Assert.Equal("Home", redirectResult.ControllerName);
            Assert.Equal("Index", redirectResult.ActionName);
        }

        [Fact(DisplayName = "When the JsonIndex action is called a Json response is produced")]
        public void JsonActionMethod()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var jsonResult = exampleController.JsonIndex();

            // Assert
            Assert.Equal(new[] {"Alice", "Bob", "Joe"}, jsonResult.Value);
        }

        [Fact(DisplayName = "When the StatusCodeIndex action is called a 404 response is produced")]
        public void StatusCodeActionMethod()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var statusCodeResult = exampleController.StatusCodeIndex();

            // Assert
            Assert.Equal(404, statusCodeResult.StatusCode);
        }
    }
}
