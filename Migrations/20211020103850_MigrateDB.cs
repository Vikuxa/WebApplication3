using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class MigrateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peremeshenies_Pomeshenies_pomeshenieid",
                table: "Peremeshenies");

            migrationBuilder.DropForeignKey(
                name: "FK_Peremeshenies_Technikas_technikaid",
                table: "Peremeshenies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rashod_Materials_Materials_materialid",
                table: "Rashod_Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Pomeshenies_pomeshenieid",
                table: "Technikas");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Sotrudnikis_sotrudnikiid",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Technikas_pomeshenieid",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Peremeshenies_pomeshenieid",
                table: "Peremeshenies");

            migrationBuilder.DropIndex(
                name: "IX_Peremeshenies_technikaid",
                table: "Peremeshenies");

            migrationBuilder.DropColumn(
                name: "pomeshenieid",
                table: "Technikas");

            migrationBuilder.DropColumn(
                name: "pomeshenieid",
                table: "Peremeshenies");

            migrationBuilder.DropColumn(
                name: "technikaid",
                table: "Peremeshenies");

            migrationBuilder.RenameColumn(
                name: "sotrudnikiid",
                table: "Technikas",
                newName: "Technikaid");

            migrationBuilder.RenameIndex(
                name: "IX_Technikas_sotrudnikiid",
                table: "Technikas",
                newName: "IX_Technikas_Technikaid");

            migrationBuilder.RenameColumn(
                name: "materialid",
                table: "Rashod_Materials",
                newName: "Pomeshenieid");

            migrationBuilder.RenameIndex(
                name: "IX_Rashod_Materials_materialid",
                table: "Rashod_Materials",
                newName: "IX_Rashod_Materials_Pomeshenieid");

            migrationBuilder.AddColumn<int>(
                name: "id_technika",
                table: "Rashod_Materials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_sotrudnik",
                table: "Peremeshenies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_id_pomeshenie",
                table: "Technikas",
                column: "id_pomeshenie");

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_id_sotrudnik",
                table: "Technikas",
                column: "id_sotrudnik");

            migrationBuilder.CreateIndex(
                name: "IX_Rashod_Materials_id_material",
                table: "Rashod_Materials",
                column: "id_material");

            migrationBuilder.CreateIndex(
                name: "IX_Rashod_Materials_id_technika",
                table: "Rashod_Materials",
                column: "id_technika");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_id_pomeshenie",
                table: "Peremeshenies",
                column: "id_pomeshenie");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_id_sotrudnik",
                table: "Peremeshenies",
                column: "id_sotrudnik");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_id_technika",
                table: "Peremeshenies",
                column: "id_technika");

            migrationBuilder.AddForeignKey(
                name: "FK_Peremeshenies_Pomeshenies_id_pomeshenie",
                table: "Peremeshenies",
                column: "id_pomeshenie",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peremeshenies_Sotrudnikis_id_sotrudnik",
                table: "Peremeshenies",
                column: "id_sotrudnik",
                principalTable: "Sotrudnikis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peremeshenies_Technikas_id_technika",
                table: "Peremeshenies",
                column: "id_technika",
                principalTable: "Technikas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rashod_Materials_Materials_id_material",
                table: "Rashod_Materials",
                column: "id_material",
                principalTable: "Materials",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rashod_Materials_Pomeshenies_Pomeshenieid",
                table: "Rashod_Materials",
                column: "Pomeshenieid",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rashod_Materials_Technikas_id_technika",
                table: "Rashod_Materials",
                column: "id_technika",
                principalTable: "Technikas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Pomeshenies_id_pomeshenie",
                table: "Technikas",
                column: "id_pomeshenie",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Sotrudnikis_id_sotrudnik",
                table: "Technikas",
                column: "id_sotrudnik",
                principalTable: "Sotrudnikis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Technikas_Technikaid",
                table: "Technikas",
                column: "Technikaid",
                principalTable: "Technikas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peremeshenies_Pomeshenies_id_pomeshenie",
                table: "Peremeshenies");

            migrationBuilder.DropForeignKey(
                name: "FK_Peremeshenies_Sotrudnikis_id_sotrudnik",
                table: "Peremeshenies");

            migrationBuilder.DropForeignKey(
                name: "FK_Peremeshenies_Technikas_id_technika",
                table: "Peremeshenies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rashod_Materials_Materials_id_material",
                table: "Rashod_Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Rashod_Materials_Pomeshenies_Pomeshenieid",
                table: "Rashod_Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Rashod_Materials_Technikas_id_technika",
                table: "Rashod_Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Pomeshenies_id_pomeshenie",
                table: "Technikas");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Sotrudnikis_id_sotrudnik",
                table: "Technikas");

            migrationBuilder.DropForeignKey(
                name: "FK_Technikas_Technikas_Technikaid",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Technikas_id_pomeshenie",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Technikas_id_sotrudnik",
                table: "Technikas");

            migrationBuilder.DropIndex(
                name: "IX_Rashod_Materials_id_material",
                table: "Rashod_Materials");

            migrationBuilder.DropIndex(
                name: "IX_Rashod_Materials_id_technika",
                table: "Rashod_Materials");

            migrationBuilder.DropIndex(
                name: "IX_Peremeshenies_id_pomeshenie",
                table: "Peremeshenies");

            migrationBuilder.DropIndex(
                name: "IX_Peremeshenies_id_sotrudnik",
                table: "Peremeshenies");

            migrationBuilder.DropIndex(
                name: "IX_Peremeshenies_id_technika",
                table: "Peremeshenies");

            migrationBuilder.DropColumn(
                name: "id_technika",
                table: "Rashod_Materials");

            migrationBuilder.DropColumn(
                name: "id_sotrudnik",
                table: "Peremeshenies");

            migrationBuilder.RenameColumn(
                name: "Technikaid",
                table: "Technikas",
                newName: "sotrudnikiid");

            migrationBuilder.RenameIndex(
                name: "IX_Technikas_Technikaid",
                table: "Technikas",
                newName: "IX_Technikas_sotrudnikiid");

            migrationBuilder.RenameColumn(
                name: "Pomeshenieid",
                table: "Rashod_Materials",
                newName: "materialid");

            migrationBuilder.RenameIndex(
                name: "IX_Rashod_Materials_Pomeshenieid",
                table: "Rashod_Materials",
                newName: "IX_Rashod_Materials_materialid");

            migrationBuilder.AddColumn<int>(
                name: "pomeshenieid",
                table: "Technikas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pomeshenieid",
                table: "Peremeshenies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "technikaid",
                table: "Peremeshenies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_pomeshenieid",
                table: "Technikas",
                column: "pomeshenieid");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_pomeshenieid",
                table: "Peremeshenies",
                column: "pomeshenieid");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_technikaid",
                table: "Peremeshenies",
                column: "technikaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Peremeshenies_Pomeshenies_pomeshenieid",
                table: "Peremeshenies",
                column: "pomeshenieid",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peremeshenies_Technikas_technikaid",
                table: "Peremeshenies",
                column: "technikaid",
                principalTable: "Technikas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rashod_Materials_Materials_materialid",
                table: "Rashod_Materials",
                column: "materialid",
                principalTable: "Materials",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Pomeshenies_pomeshenieid",
                table: "Technikas",
                column: "pomeshenieid",
                principalTable: "Pomeshenies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technikas_Sotrudnikis_sotrudnikiid",
                table: "Technikas",
                column: "sotrudnikiid",
                principalTable: "Sotrudnikis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
