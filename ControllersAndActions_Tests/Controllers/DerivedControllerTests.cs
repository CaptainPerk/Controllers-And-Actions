using ControllersAndActions.Controllers;
using Xunit;

namespace ControllersAndActions_Tests.Controllers
{
    public class DerivedControllerTests
    {
        [Fact(DisplayName = "When the Index action is called the DictionaryResult view is selected")]
        public void CorrectViewSelected()
        {
            // Arrange
            var derivedController = new DerivedController();

            // Act
            var viewResult = derivedController.Index();

            //Arrange
            Assert.Equal("Result", viewResult.ViewName);
        }
    }
}
