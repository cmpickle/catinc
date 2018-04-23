// using Microsoft.EntityFrameworkCore;
// using catinc.Models.Domain;

// namespace catinc.Models.Database
// {
//     public class MyDbContext : DbContext
//     {
//         public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
//         {
//             Database.EnsureCreated();
//         }

//         public DbSet<Vendor> Vendors { get; set; }
//         public DbSet<MyIdentityUser> Users { get; set; }
//         public DbSet<VendorUser> VendorUsers { get; set; }

//         protected override void OnModelCreating(ModelBuilder builder)
//         {
//             builder.Entity<Vendor>().HasMany(v => v.VendorUsers).WithOne(vu => vu.Vendor);
//             builder.Entity<MyIdentityUser>().HasMany(u => u.VendorUsers).WithOne(vu => vu.User);
//         }
//     }
// }