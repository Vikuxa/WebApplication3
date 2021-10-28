using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class Migrate101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rashod_Materials_Pomeshenies_Pomeshenieid",
                table: "Rashod_Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Technikas_Technikaid",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Technikas_Technikaid",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Rashod_Materials_Pomeshenieid",
                table: "Rashod_Materials");

            migrationBuilder.DropColumn(
                name: "Technikaid",
                table: "Technikas");

            migrationBuilder.DropColumn(
                name: "Pomeshenieid",
                table: "Rashod_Materials");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Technikaid",
                table: "Technikas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pomeshenieid",
                table: "Rashod_Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_Technikaid",
                table: "Technikas",
                column: "Technikaid");

            migrationBuilder.CreateIndex(
                name: "IX_Rashod_Materials_Pomeshenieid",
                table: "Rashod_Materials",
                column: "Pomeshenieid");

            migrationBuilder.AddForeignKey(
                name: "FK_Rashod_Materials_Pomeshenies_Pomeshenieid",
                table: "Rashod_Materials",
                column: "Pomeshenieid",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Technikas_Technikaid",
                table: "Technikas",
                column: "Technikaid",
                principalTable: "Technikas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
