using ControllersAndActions.Controllers;
using System;
using Xunit;

namespace ControllersAndActions_Tests.Controllers
{
    public class ExampleControllerTests
    {
        [Fact(DisplayName = "The model of the Index view is a DateTime")]
        public void CorrectModelTypeISUsed()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var viewResult = exampleController.Index();

            // Assert
            Assert.IsType<DateTime>(viewResult.ViewData.Model);
        }
    }
}
