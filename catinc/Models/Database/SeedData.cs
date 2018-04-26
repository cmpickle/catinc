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
                Vendor psych = null;
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
                            VendorCreditcardNo = 123456781
                        },
                        psych = new Vendor
                        {
                            VendorName = "Psych",
                            VendorEmail = "cmon@son.interweb",
                            VendorAddress = "100 Oceanside Ave",
                            VendorTelephoneNo = "9015555555",
                            VendorCreditcardNo = 123456782
                        },
                        carmicheal = new Vendor
                        {
                            VendorName = "Carmicheal Industries",
                            VendorEmail = "intersect@carmicheal.com",
                            VendorAddress = "1257 Buymoria Burbank CA",
                            VendorTelephoneNo = "9025555555",
                            VendorCreditcardNo = 123456780
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
                        },
                        garbage = new MyIdentityUser
                        {
                            Id = "2c84da0e-2134-44e4-b6aa-8a88f035d846",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d140b68-af83-4b56-b692-2161af80500e",
                            Email = "test1@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            LockoutEnd = null,
                            NormalizedEmail = "TEST1@TEST.COM",
                            NormalizedUserName = "TEST1@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECHsyeaF0iFuahlYZFJXpbaibNLCMomnVCySupwES3zuXHYD/jzn80QNIZFVVrTPlw==",
                            PhoneNumber = null,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "33ae9241-eee8-41ab-97a7-62ef99813834",
                            TwoFactorEnabled = false,
                            UserName = "test1@test.com"
                        },
                        garbage = new MyIdentityUser
                        {
                            Id = "6897bcee-59be-45d4-aafc-8e137702c1d6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0783360d-2973-40fa-b448-64fa5b7dc231",
                            Email = "test2@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            LockoutEnd = null,
                            NormalizedEmail = "TEST2@TEST.COM",
                            NormalizedUserName = "TEST2@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENVEXH1hweYJRlsbI1/cb3DrvvK1P8pDCmh2S1HVQTngE/VtphjoFp13/WDtOIee1w==",
                            PhoneNumber = null,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bc06cab4-e05c-410d-8d4f-c81b7c79c3c8",
                            TwoFactorEnabled = false,
                            UserName = "test2@test.com"
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
                        },
                        new VendorUser
                        {
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Psych")),
                            User = context.MyIdentityUsers.FirstOrDefault(u => u.UserName.Equals("test1@test.com")),
                        },
                        new VendorUser
                        {
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Flatlanders")),
                            User = context.MyIdentityUsers.FirstOrDefault(u => u.UserName.Equals("test2@test.com")),
                        },
                        new VendorUser
                        {
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Krusty Krab")),
                            User = context.MyIdentityUsers.FirstOrDefault(u => u.UserName.Equals("test@test.com")),
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
                        },
                        new Product
                        {
                            ProductSKU = "1237",
                            ProductName = "Nerd Herd Service",
                            ProductShortDescription = "Best service you can buy.",
                            ProductLongDescription = "The Buymore's service that will cover you on any of your home electronics needs.",
                            ProductPrice = 200.00M,
                            ProductInventory = 999,
                            ProductImageURL = "/images/nerdherd.png",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Carmicheal Industries")),
                        },
                        new Product
                        {
                            ProductSKU = "1238",
                            ProductName = "Intersect Glasses",
                            ProductShortDescription = "Government secrets in glasses.",
                            ProductLongDescription = "Become a super spy with all of the goverments secrets stored in your head.",
                            ProductPrice = 10000.00M,
                            ProductInventory = 2,
                            ProductImageURL = "/images/intersect.jpg",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Carmicheal Industries")),
                        },
                        new Product
                        {
                            ProductSKU = "1239",
                            ProductName = "Pineapple",
                            ProductShortDescription = "A fresh Pineapple.",
                            ProductLongDescription = "A fresh California pineapple! You might even convince Shawn to cut it for you if your are peckish enough.",
                            ProductPrice = 10.00M,
                            ProductInventory = 30,
                            ProductImageURL = "/images/pineapple.jpg",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Psych")),
                        },
                        new Product
                        {
                            ProductSKU = "1240",
                            ProductName = "Blueberry",
                            ProductShortDescription = "The Blueberry in all it's glory.",
                            ProductLongDescription = "You may not be a gifted psychic detective but you can drive around like one!",
                            ProductPrice = 15000.00M,
                            ProductInventory = 5,
                            ProductImageURL = "/images/blueberry.jpg",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Psych")),
                        },
                        new Product
                        {
                            ProductSKU = "1241",
                            ProductName = "Krabby Patty",
                            ProductShortDescription = "Finest Sandwich in the sea.",
                            ProductLongDescription = "This sanwich will make your sould delight when you sample it's greatness.",
                            ProductPrice = 5.00M,
                            ProductInventory = 50,
                            ProductImageURL = "/images/krabbypatty.jpg",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Krusty Krab")),
                        },
                        new Product
                        {
                            ProductSKU = "1242",
                            ProductName = "Krust Krab Pizza",
                            ProductShortDescription = "Is the Pizza",
                            ProductLongDescription = "The Krusty Krab Pizza is the pizza for you and me!",
                            ProductPrice = 10.00M,
                            ProductInventory = 20,
                            ProductImageURL = "/images/krustykrabpizza.png",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Krusty Krab")),
                        },
                        new Product
                        {
                            ProductSKU = "1243",
                            ProductName = "Jelly Fish Jelly",
                            ProductShortDescription = "Made from real jellyfish.",
                            ProductLongDescription = "Made from real jellyfish you can put it on your Krabby Patty.",
                            ProductPrice = 10.00M,
                            ProductInventory = 35,
                            ProductImageURL = "/images/jellyfishjelly.jpg",
                            Vendor = context.Vendors.FirstOrDefault(v => v.VendorName.Equals("Krusty Krab")),
                        }
                    );
               }
               context.SaveChanges();
            }
        }
    }
}