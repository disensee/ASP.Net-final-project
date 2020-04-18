using Microsoft.EntityFrameworkCore.Migrations;

namespace HardwareEFCore.Migrations
{
    public partial class scrapphotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildPhoto_Computers_ComputerId",
                table: "BuildPhoto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildPhoto",
                table: "BuildPhoto");

            migrationBuilder.RenameTable(
                name: "BuildPhoto",
                newName: "BuildPhotos");

            migrationBuilder.RenameIndex(
                name: "IX_BuildPhoto_ComputerId",
                table: "BuildPhotos",
                newName: "IX_BuildPhotos_ComputerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildPhotos",
                table: "BuildPhotos",
                column: "BuildPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildPhotos_Computers_ComputerId",
                table: "BuildPhotos",
                column: "ComputerId",
                principalTable: "Computers",
                principalColumn: "ComputerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildPhotos_Computers_ComputerId",
                table: "BuildPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BuildPhotos",
                table: "BuildPhotos");

            migrationBuilder.RenameTable(
                name: "BuildPhotos",
                newName: "BuildPhoto");

            migrationBuilder.RenameIndex(
                name: "IX_BuildPhotos_ComputerId",
                table: "BuildPhoto",
                newName: "IX_BuildPhoto_ComputerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BuildPhoto",
                table: "BuildPhoto",
                column: "BuildPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildPhoto_Computers_ComputerId",
                table: "BuildPhoto",
                column: "ComputerId",
                principalTable: "Computers",
                principalColumn: "ComputerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
