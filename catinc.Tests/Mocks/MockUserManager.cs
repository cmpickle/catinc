using System;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;

namespace catinc.Tests.Mocks
{
    /// <summary>
    /// Mocked Identity UserManager for unit tests
    /// </summary>
    public class MockUserManager : UserManager<MyIdentityUser>
    {
        public MockUserManager()
            : base(
                new Mock<IUserStore<MyIdentityUser>>().Object,
                new Mock<IOptions<IdentityOptions>>().Object,
                new Mock<IPasswordHasher<MyIdentityUser>>().Object,
                new IUserValidator<MyIdentityUser>[0],
                new IPasswordValidator<MyIdentityUser>[0],
                new Mock<ILookupNormalizer>().Object,
                new Mock<IdentityErrorDescriber>().Object,
                new Mock<IServiceProvider>().Object,
                new Mock<ILogger<UserManager<MyIdentityUser>>>().Object
            )
        { }
        public override IQueryable<MyIdentityUser> Users { get; }
    }
}