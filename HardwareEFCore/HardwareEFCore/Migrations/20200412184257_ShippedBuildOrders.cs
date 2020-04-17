using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareEFCore.Migrations
{
    public partial class ShippedBuildOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "BuildOrders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "BuildOrders");
        }
    }
}
