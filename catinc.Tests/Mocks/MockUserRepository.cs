using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace catinc.Tests.Mocks
{
    public class MockUserRepository<TUser> : UserRepository
    {
        /// <summary>
        /// Mock UserRepository for unit tests
        /// </summary>
        public MockUserRepository() 
            : base(new Mock<IUserManager<MyIdentityUser>>().Object)
        {}
    }
}