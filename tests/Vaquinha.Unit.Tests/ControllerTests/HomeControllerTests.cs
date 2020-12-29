using Microsoft.Extensions.Logging;
using Moq;
using Vaquinha.MVC.Controllers;
using Vaquinha.Domain;
using Xunit;
using NToastNotify;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FluentAssertions;

namespace Vaquinha.Unit.Tests.ControllerTests
{
    public class HomeControllerTests
    {

        private readonly Mock<IHomeInfoService> _homeInfoService = new Mock<IHomeInfoService>();
        private readonly Mock<ILogger<HomeController>> _logger = new Mock<ILogger<HomeController>>();
        private Mock<IToastNotification> _toastNotification = new Mock<IToastNotification>();
        public HomeControllerTests()
        {

        }
        [Trait("HomeController", "HomeController_RetornaHomeComSucesso")]
        [Fact]
        public void HomeController_RetornaHomeComSucesso() {
            // Arrange
            var controller = new HomeController(_logger.Object,_homeInfoService.Object,_toastNotification.Object);
            // Act
            var result = controller.Index();
            // Assert
            result.Should().BeOfType<Task<IActionResult>>();
        }
    }
}
