﻿using ControllersAndActions.Controllers;
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

        [Fact(DisplayName = "When the Redirect action is called the user is redirected to the Index action")]
        public void Redirection()
        {
            // Arrange
            var exampleController = new ExampleController();

            // Act
            var redirectResult = exampleController.Redirect();

            // Assert
            Assert.False(redirectResult.Permanent);
            Assert.Equal("Example", redirectResult.RouteValues["controller"]);
            Assert.Equal("Index", redirectResult.RouteValues["action"]);
            Assert.Equal("MyID", redirectResult.RouteValues["ID"]);
        }
    }
}
