using NUnit.Framework;
using catinc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController homeController;

        [SetUp]
        public void SetUp()
        {
            homeController = new HomeController();
        }

        [Test]
        public void RouteToIndex()
        {
            Assert.That(typeof(IActionResult).IsInstanceOfType(homeController.Index()));
        }

        [Test]
        public void RouteToAbout()
        {
            Assert.That(typeof(IActionResult).IsInstanceOfType(homeController.About()));
        }

        [Test]
        public void RouteToContact()
        {
            Assert.That(typeof(IActionResult).IsInstanceOfType(homeController.Contact()));
        }
    }
}