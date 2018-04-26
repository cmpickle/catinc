using catinc.Repositories;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace catinc.Tests.Mocks
{
    public class MockProductRepository : ProductRepository
    {
        static DbContextOptions<MySqlDbContext> options = new DbContextOptionsBuilder<MySqlDbContext>()
            .UseInMemoryDatabase(databaseName: "cmpickle")
            .Options;

        static MySqlDbContext context = new MySqlDbContext(options);

        /// <summary>
        /// Mock ProductRepository for unit tests
        /// </summary>
        public MockProductRepository() 
            : base(context)
        {}
    }
}