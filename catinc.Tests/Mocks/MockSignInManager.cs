using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using catinc.Models.Domain;
using Moq;
using catinc.Models.MemberSystem;

namespace catinc.Tests.Mocks
{
    /// <summary>
    /// Mocke SignInManager for unit tests
    /// </summary>
    public class MockSignInManager<TUser> : MySignInManager<MyIdentityUser>
    {
        public MockSignInManager()
            : base(new Mock<MockUserManager>().Object,
                  new HttpContextAccessor(),
                  new Mock<IUserClaimsPrincipalFactory<MyIdentityUser>>().Object,
                  new Mock<IOptions<IdentityOptions>>().Object,
                  new Mock<ILogger<SignInManager<MyIdentityUser>>>().Object, 
                  new Mock<IAuthenticationSchemeProvider>().Object)
        { }
    }
}