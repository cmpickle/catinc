using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace catinc.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Creditcards",
                columns: table => new
                {
                    CreditcardID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CCV = table.Column<int>(nullable: false),
                    CreditcardNo = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creditcards", x => x.CreditcardID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    DiscountID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiscountEnd = table.Column<DateTime>(nullable: false),
                    DiscountStart = table.Column<DateTime>(nullable: false),
                    IsDiscountDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.DiscountID);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LogLevel = table.Column<int>(nullable: false),
                    LogMessage = table.Column<string>(nullable: true),
                    LogTimestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Loyaltys",
                columns: table => new
                {
                    LoyaltyID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LoyaltyPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loyaltys", x => x.LoyaltyID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermissionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsVendorActive = table.Column<bool>(nullable: false),
                    IsVendorDeleted = table.Column<bool>(nullable: false),
                    IsVendorSuspended = table.Column<bool>(nullable: false),
                    VendorAddress = table.Column<string>(nullable: true),
                    VendorCreditcardNo = table.Column<int>(nullable: false),
                    VendorEmail = table.Column<string>(nullable: true),
                    VendorName = table.Column<string>(nullable: true),
                    VendorPaymentAmount = table.Column<decimal>(nullable: false),
                    VendorTelephoneNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "VendorUserPermission",
                columns: table => new
                {
                    VendorUserPermissionID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermissionLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorUserPermission", x => x.VendorUserPermissionID);
                });

            migrationBuilder.CreateTable(
                name: "MyIdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LogID = table.Column<int>(nullable: true),
                    LoyaltyID = table.Column<int>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PermissionID = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyIdentityUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyIdentityUser_Logs_LogID",
                        column: x => x.LogID,
                        principalTable: "Logs",
                        principalColumn: "LogID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyIdentityUser_Loyaltys_LoyaltyID",
                        column: x => x.LoyaltyID,
                        principalTable: "Loyaltys",
                        principalColumn: "LoyaltyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MyIdentityUser_Permissions_PermissionID",
                        column: x => x.PermissionID,
                        principalTable: "Permissions",
                        principalColumn: "PermissionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsProductedDeleted = table.Column<bool>(nullable: false),
                    ProductExpirationDate = table.Column<DateTime>(nullable: false),
                    ProductImageURL = table.Column<string>(nullable: true),
                    ProductInventory = table.Column<int>(nullable: false),
                    ProductLongDescription = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    ProductSKU = table.Column<string>(nullable: true),
                    ProductShortDescription = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiscountID = table.Column<int>(nullable: true),
                    OrderTimestamp = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "DiscountID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_MyIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MyIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patrons",
                columns: table => new
                {
                    PatronID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsPatronDeleted = table.Column<bool>(nullable: false),
                    IsPatronSuspended = table.Column<bool>(nullable: false),
                    PatronAddress = table.Column<string>(nullable: true),
                    PatronEmail = table.Column<string>(nullable: true),
                    PatronFirst = table.Column<string>(nullable: true),
                    PatronLast = table.Column<string>(nullable: true),
                    PatronTelephoneNo = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrons", x => x.PatronID);
                    table.ForeignKey(
                        name: "FK_Patrons_MyIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MyIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorUsers",
                columns: table => new
                {
                    VendorUserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    VendorId = table.Column<int>(nullable: true),
                    VendorUserPermissionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorUsers", x => x.VendorUserId);
                    table.ForeignKey(
                        name: "FK_VendorUsers_MyIdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "MyIdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorUsers_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorUsers_VendorUserPermission_VendorUserPermissionID",
                        column: x => x.VendorUserPermissionID,
                        principalTable: "VendorUserPermission",
                        principalColumn: "VendorUserPermissionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrders",
                columns: table => new
                {
                    ProductOrderID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderID = table.Column<int>(nullable: true),
                    OrderID1 = table.Column<int>(nullable: true),
                    ProductID = table.Column<int>(nullable: true),
                    ProductID1 = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrders", x => x.ProductOrderID);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Orders_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOrders_Products_ProductID1",
                        column: x => x.ProductID1,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatronCreditcards",
                columns: table => new
                {
                    PatronCreditcardID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreditcardID = table.Column<int>(nullable: true),
                    PatronID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatronCreditcards", x => x.PatronCreditcardID);
                    table.ForeignKey(
                        name: "FK_PatronCreditcards_Creditcards_CreditcardID",
                        column: x => x.CreditcardID,
                        principalTable: "Creditcards",
                        principalColumn: "CreditcardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatronCreditcards_Patrons_PatronID",
                        column: x => x.PatronID,
                        principalTable: "Patrons",
                        principalColumn: "PatronID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyIdentityUser_LogID",
                table: "MyIdentityUser",
                column: "LogID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyIdentityUser_LoyaltyID",
                table: "MyIdentityUser",
                column: "LoyaltyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyIdentityUser_PermissionID",
                table: "MyIdentityUser",
                column: "PermissionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountID",
                table: "Orders",
                column: "DiscountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatronCreditcards_CreditcardID",
                table: "PatronCreditcards",
                column: "CreditcardID");

            migrationBuilder.CreateIndex(
                name: "IX_PatronCreditcards_PatronID",
                table: "PatronCreditcards",
                column: "PatronID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_UserId",
                table: "Patrons",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderID",
                table: "ProductOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_OrderID1",
                table: "ProductOrders",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ProductID",
                table: "ProductOrders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrders_ProductID1",
                table: "ProductOrders",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorUsers_UserId",
                table: "VendorUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorUsers_VendorId",
                table: "VendorUsers",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorUsers_VendorUserPermissionID",
                table: "VendorUsers",
                column: "VendorUserPermissionID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatronCreditcards");

            migrationBuilder.DropTable(
                name: "ProductOrders");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VendorUsers");

            migrationBuilder.DropTable(
                name: "Creditcards");

            migrationBuilder.DropTable(
                name: "Patrons");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "VendorUserPermission");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "MyIdentityUser");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Loyaltys");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
