using NUnit.Framework;
using catinc.Controllers;
using catinc.Models.MemberSystem;
using catinc.Models.Domain;
using catinc.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using catinc.Models.ViewModels.AccountViewModels;

namespace catinc.Tests.Controllers
{
    [TestFixture]
    public class AccountControllerTests
    {
        private AccountController accountController;

        [SetUp]
        public void SetUp()
        {
            accountController = new AccountController(userRepository: new MockUserRepository<MyIdentityUser>(), signInManager: new MockSignInManager<MyIdentityUser>(), emailSender: new MockEmailSender(), logger: new MockLogger<AccountController>());
        }

        [Test]
        public void RouteToLogin()
        {
            Assert.That(typeof(ViewResult).IsInstanceOfType(accountController.Login(new LoginViewModel {
            }).Result));
        }

        [Test]
        public void RouteToLockout()
        {
            Assert.That(typeof(ViewResult).IsInstanceOfType(accountController.Lockout()));
        }

        [Test]
        public void RouteToRegister()
        {
            Assert.That(typeof(ViewResult).IsInstanceOfType(accountController.Register()));
        }
    }
}