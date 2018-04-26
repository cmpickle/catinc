using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using catinc.Models.Domain;

namespace catinc.Models.Database
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MySqlDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MySqlDbContext>>()))
            {
                Vendor flatlanders = null;
                Vendor krustykrab = null;
                Vendor carmicheal = null;
                if (!context.Vendors.Any())
                {
                    context.Vendors.AddRange(
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
                if (!context.MyIdentityUsers.Any())
                {
                    context.MyIdentityUsers.AddRange(
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
                        },
                        garbage = new MyIdentityUser
                        {
                            Id = "f7ee9a14-7208-43bb-acc3-78b2ead68584",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e3c242b7-317e-477f-a3dd-aac03f6ea31d",
                            Email = "test@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            LockoutEnd = null,
                            NormalizedEmail = "TEST@TEST.COM",
                            NormalizedUserName = "TEST@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKKxA5vr/8DpWn47nL7S+59MIsJXY8LlN0PhcncoAtCJ5+RExPAX+MqvJakVRrHAfg==",
                            PhoneNumber = null,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "686334eb-18a2-44e8-9758-0529266883f4",
                            TwoFactorEnabled = false,
                            UserName = "test@test.com"
                        }
                    );
                }

                if (!context.VendorUsers.Any())
                {
                    context.VendorUsers.AddRange(
                        new VendorUser
                        {
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Carmicheal Industries")),
                            User = context.MyIdentityUsers.FirstOrDefault(u => u.UserName.Equals("parathegarbage@gmail.com")),
                        }
                    );
               }

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            ProductSKU = "1234",
                            ProductName = "Azurite Gem",
                            ProductShortDescription = "Azurite Gem is cool",
                            ProductLongDescription = "Azurite Gem is cool, so cool it has a long description.",
                            ProductPrice = 7.56M,
                            ProductInventory = 12,
                            ProductImageURL = "/images/gem-01.gif",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Flatlanders")),
                        },
                        new Product
                        {
                            ProductSKU = "1235",
                            ProductName = "Bloodstone Gem",
                            ProductShortDescription = "Bloodstone Gem is rare",
                            ProductLongDescription = "Bloodstone Gem is awesome, I would buy 100 if I could afford them.",
                            ProductPrice = 1000.00M,
                            ProductInventory = 2,
                            ProductImageURL = "/images/gem-02.gif",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Flatlanders")),
                        },
                        new Product
                        {
                            ProductSKU = "1236",
                            ProductName = "Dodecahedron Gem",
                            ProductShortDescription = "Dodecahedron Gem has 10 faces",
                            ProductLongDescription = "Dodecahedron Gem is rather common, it's still really shiny.",
                            ProductPrice = 100.00M,
                            ProductInventory = 200,
                            ProductImageURL = "/images/gem-03.gif",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Flatlanders")),
                        }
                    );
               }
               context.SaveChanges();
            }
        }
    }
}