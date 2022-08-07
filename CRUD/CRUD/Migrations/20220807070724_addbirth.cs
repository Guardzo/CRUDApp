using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD.Migrations
{
    public partial class addbirth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "MangoUser");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "MangoUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "MangoUser");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "MangoUser",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
