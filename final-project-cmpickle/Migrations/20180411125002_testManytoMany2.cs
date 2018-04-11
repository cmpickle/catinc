using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace finalprojectcmpickle.Migrations
{
    public partial class testManytoMany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserID",
                table: "VendorUser",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "VendorUser",
                nullable: false,
                oldClrType: typeof(Guid));
        }
    }
}
