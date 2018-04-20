using System;
using System.Linq;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.MemberSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace final_project_cmpickle.Models.Database
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MySqlDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MySqlDbContext>>()))
            {
                Vendor flatlanders;
                Vendor krustykrab;
                Vendor carmicheal = null;
                if (!context.Vendor.Any())
                {
                    context.Vendor.AddRange(
                        flatlanders = new Vendor
                        {
                            VendorName = "Flatlanders",
                            VendorEmail = "gems@flatlanders.net",
                            VendorAddress = "1234 Gemeral Store Ave",
                            VendorTelephoneNo = "8015555555",
                            VendorCreditcardNo = 123456789
                        },
                        krustykrab = new Vendor
                        {
                            VendorName = "Krusty Krab",
                            VendorEmail = "money@krustykrab.web",
                            VendorAddress = "1 Bikini Bottom Ave",
                            VendorTelephoneNo = "9015555555",
                            VendorCreditcardNo = 123456780
                        },
                        carmicheal = new Vendor
                        {
                            VendorName = "Carmicheal Industries",
                            VendorEmail = "intersect@carmicheal.com",
                            VendorAddress = "1257 Buymoria Burbank CA",
                            VendorTelephoneNo = "9025555555",
                            VendorCreditcardNo = 123456781
                        }
                    );
                }

                MyIdentityUser garbage = null;
                if (!context.MyIdentityUser.Any())
                {
                    context.MyIdentityUser.AddRange(
                        garbage = new MyIdentityUser
                        {
                            Id = "dffbb9d9-6d79-449b-b15a-8fcd79aec080",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "907442b2-1566-4517-a76b-aeb7da414bdd",
                            Email = "parathegarbage@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            LockoutEnd = null,
                            NormalizedEmail = "PARATHEGARBAGE@GMAIL.COM",
                            NormalizedUserName = "PARATHEGARBAGE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO8cHLaiaPOreeFsEYJYSSmBJAy/POwCpwkOiz2hKSzwQb7+ZRaQB2JmeM5r6TzMQQ==",
                            PhoneNumber = null,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9a111107-326e-404a-af70-3fed42bcbbc7",
                            TwoFactorEnabled = false,
                            UserName = "parathegarbage@gmail.com"
                        }
                    );
                }

                if (!context.VendorUser.Any())
                {
                    context.VendorUser.AddRange(
                        new VendorUser
                        {
                            Vendor = carmicheal,
                            Users = garbage
                        }
                    );
               }
               context.SaveChanges();
            }
        }
    }
}