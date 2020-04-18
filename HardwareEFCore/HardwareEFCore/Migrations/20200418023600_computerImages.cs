using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareEFCore.Migrations
{
    public partial class computerImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Computers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Computers");
        }
    }
}
