using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace catinc.Tests.Mocks
{
    public class MockVendorRepository : VendorRepository
    {
        static DbContextOptions<MySqlDbContext> options = new DbContextOptionsBuilder<MySqlDbContext>()
            .UseInMemoryDatabase(databaseName: "cmpickle")
            .Options;

        static MySqlDbContext context = new MySqlDbContext(options);

        public MockVendorRepository() 
            : base(context,
                    new Mock<IUserManager<MyIdentityUser>>().Object)
        {}
    }
}