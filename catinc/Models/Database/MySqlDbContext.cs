using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using catinc.Models.Domain;

namespace catinc.Models.Database
{
    public class MySqlDbContext : IdentityDbContext<MyIdentityUser>
    {
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Creditcard> Creditcards { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Loyalty> Loyaltys { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<PatronCreditcard> PatronCreditcards { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<MyIdentityUser> MyIdentityUsers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorUser> VendorUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vendor>().HasMany(v => v.VendorUsers).WithOne(vu => vu.Vendor);
            builder.Entity<MyIdentityUser>().HasMany(u => u.VendorUsers).WithOne(vu => vu.User);

            builder.Entity<Patron>().HasMany(p => p.PatronCreditcards).WithOne(pc => pc.Patron);
            builder.Entity<Creditcard>().HasMany(c => c.PatronCreditcards).WithOne(pc => pc.Creditcard);

            builder.Entity<Orders>().HasMany(o => o.ProductOrders).WithOne(po => po.Order);
            builder.Entity<Product>().HasMany(p => p.ProductOrders).WithOne(po => po.Product);

            builder.Entity<Orders>(b =>
            {
                b.HasKey(o => o.OrderID);
            });

            builder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(i => i.UserId);
            });

            builder.Entity<IdentityUserRole<string>>(b =>
            {
                b.HasKey(i => i.UserId);
            });

            builder.Entity<IdentityUserToken<string>>(b =>
            {
                b.HasKey(i => i.UserId);
            });
        }
    }
}