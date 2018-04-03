using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using final_project_cmpickle.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.Database
{
  public class MySqlDbContext : IdentityDbContext<MyIdentityUser>
  {
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {
      Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.UseMySql("Server=67.205.183.11;Database=cmpickle;Uid=cmpickle;Pwd=Photog42;");
    }

    public DbSet<Creditcard> Creditcard { get; set; }

    public DbSet<Discount> Discount { get; set; }
    
    public DbSet<Log> Log { get; set; }

    public DbSet<Loyalty> Loyalty { get; set; }

    public DbSet<Orders> Orders { get; set; }

    public DbSet<Patron> Patron { get; set; }

    public DbSet<PatronCreditcard> PatronCreditcard { get; set; }

    public DbSet<Permission> Permission { get; set; }

    public DbSet<Product> Product { get; set; }

    public DbSet<ProductOrder> ProductOrder { get; set; }

    public DbSet<Users> Users { get; set; }

    public DbSet<Vendor> Vendor { get; set; }

    public DbSet<VendorUser> VendorUser { get; set; }
  }
}