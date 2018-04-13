﻿// <auto-generated />
using final_project_cmpickle.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace finalprojectcmpickle.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20180413024032_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Creditcard", b =>
                {
                    b.Property<int>("CreditcardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CCV");

                    b.Property<int>("CreditcardNo");

                    b.Property<DateTime>("ExpirationDate");

                    b.HasKey("CreditcardID");

                    b.ToTable("Creditcard");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiscountEnd");

                    b.Property<DateTime>("DiscountStart");

                    b.Property<bool>("IsDiscountDeleted");

                    b.HasKey("DiscountID");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LogLevel");

                    b.Property<string>("LogMessage");

                    b.Property<DateTime>("LogTimestamp");

                    b.Property<int>("UserID");

                    b.HasKey("LogID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Loyalty", b =>
                {
                    b.Property<int>("LoyaltyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LoyaltyPoints");

                    b.Property<int>("UserID");

                    b.HasKey("LoyaltyID");

                    b.ToTable("Loyalty");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.MyUsers", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdentityUserID");

                    b.Property<bool>("IsUserDeleted");

                    b.HasKey("UserID");

                    b.ToTable("MyUsers");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Orders", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountID");

                    b.Property<DateTime>("OrderTimestamp");

                    b.Property<int>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Patron", b =>
                {
                    b.Property<int>("PatronID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsPatronDeleted");

                    b.Property<bool>("IsPatronSuspended");

                    b.Property<string>("PatronAddress");

                    b.Property<string>("PatronEmail");

                    b.Property<string>("PatronFirst");

                    b.Property<string>("PatronLast");

                    b.Property<string>("PatronTelephoneNo");

                    b.Property<int>("UserID");

                    b.HasKey("PatronID");

                    b.ToTable("Patron");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.PatronCreditcard", b =>
                {
                    b.Property<int>("PatronCreditcardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreditcardID");

                    b.Property<int>("PatronID");

                    b.HasKey("PatronCreditcardID");

                    b.ToTable("PatronCreditcard");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Permission", b =>
                {
                    b.Property<int>("PermissionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionLevel");

                    b.Property<int>("UserID");

                    b.HasKey("PermissionID");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsProductedDeleted");

                    b.Property<DateTime>("ProductExpirationDate");

                    b.Property<string>("ProductImageURL");

                    b.Property<int>("ProductInventory");

                    b.Property<string>("ProductLongDescription");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("ProductPrice");

                    b.Property<string>("ProductSKU");

                    b.Property<string>("ProductShortDescription");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.ProductOrder", b =>
                {
                    b.Property<int>("ProductOrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID");

                    b.Property<int?>("Orders");

                    b.Property<int?>("Product");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ProductOrderID");

                    b.HasIndex("Orders");

                    b.HasIndex("Product");

                    b.ToTable("ProductOrder");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.Vendor", b =>
                {
                    b.Property<int>("VendorID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsVendorActive");

                    b.Property<bool>("IsVendorDeleted");

                    b.Property<bool>("IsVendorSuspended");

                    b.Property<string>("VendorAddress");

                    b.Property<int>("VendorCreditcardNo");

                    b.Property<string>("VendorEmail");

                    b.Property<string>("VendorName");

                    b.Property<decimal>("VendorPaymentAmount");

                    b.Property<string>("VendorTelephoneNo");

                    b.HasKey("VendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.VendorUser", b =>
                {
                    b.Property<int>("VendorUserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserID");

                    b.Property<int>("VendorID");

                    b.HasKey("VendorUserID");

                    b.HasIndex("UserID");

                    b.HasIndex("VendorID");

                    b.ToTable("VendorUser");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.MemberSystem.MyIdentityUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.ProductOrder", b =>
                {
                    b.HasOne("final_project_cmpickle.Models.Domain.Orders", "order")
                        .WithMany()
                        .HasForeignKey("Orders");

                    b.HasOne("final_project_cmpickle.Models.Domain.Product", "product")
                        .WithMany()
                        .HasForeignKey("Product");
                });

            modelBuilder.Entity("final_project_cmpickle.Models.Domain.VendorUser", b =>
                {
                    b.HasOne("final_project_cmpickle.Models.MemberSystem.MyIdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.HasOne("final_project_cmpickle.Models.Domain.Vendor", "Vendor")
                        .WithMany("VendorUsers")
                        .HasForeignKey("VendorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("final_project_cmpickle.Models.MemberSystem.MyIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("final_project_cmpickle.Models.MemberSystem.MyIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("final_project_cmpickle.Models.MemberSystem.MyIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("final_project_cmpickle.Models.MemberSystem.MyIdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
