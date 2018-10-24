using ControllersAndActions.Controllers;
using Xunit;

namespace ControllersAndActions_Tests.Controllers
{
    public class PocoControllerTests
    {
        [Fact(DisplayName = "When the Index action is called the Result view is selected")]
        public void CorrectViewSelected()
        {
            // Arrange
            var pocoController = new PocoController();

            // Act
            var viewResult = pocoController.Index();

            // Assert
            Assert.Equal("Result", viewResult.ViewName);
        }
    }
}
