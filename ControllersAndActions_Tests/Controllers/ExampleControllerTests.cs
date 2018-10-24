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

        [Fact(DisplayName = "When the NewIndex action is called a Json response is produced")]
        public void JsonActionMethod()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var jsonResult = exampleController.NewIndex();

            // Assert
            Assert.Equal(new[] {"Alice", "Bob", "Joe"}, jsonResult.Value);
        }
    }
}
