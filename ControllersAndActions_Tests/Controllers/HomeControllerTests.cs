using ControllersAndActions.Controllers;
using Xunit;

namespace ControllersAndActions_Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact(DisplayName = "When the ReceiveForm action is called the Result view is selected")]
        public void CorrectViewSelected()
        {
            // Arrange
            var homeController = new HomeController();

            // Act
            var viewResult = homeController.ReceiveForm("Adam", "London");

            // Assert
            Assert.Equal("Result", viewResult.ViewName);
        }
    }
}
