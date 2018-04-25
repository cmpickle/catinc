using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Moq;

namespace catinc.Tests.Mocks
{
    public class MockVendorRepository : VendorRepository
    {
        public MockVendorRepository() 
            : base(new Mock<MySqlDbContext>().Object,
                    new Mock<IUserManager<MyIdentityUser>>().Object)
        {}
    }
}