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
    
  }
}