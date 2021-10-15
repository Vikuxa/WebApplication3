using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pomeshenies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kab_nom = table.Column<int>(type: "int", nullable: false),
                    etazh = table.Column<int>(type: "int", nullable: false),
                    zdanie_nom = table.Column<int>(type: "int", nullable: false),
                    ulitsa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gorod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pomeshenies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sotrudnikis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    f = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    i = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    o = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dolzhnost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotrudnikis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rashod_Materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_material = table.Column<int>(type: "int", nullable: false),
                    materialid = table.Column<int>(type: "int", nullable: true),
                    data_ustanivki = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_demontazha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prichina = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rashod_Materials", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rashod_Materials_Materials_materialid",
                        column: x => x.materialid,
                        principalTable: "Materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Technikas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_sotrudnik = table.Column<int>(type: "int", nullable: false),
                    sotrudnikiid = table.Column<int>(type: "int", nullable: true),
                    id_pomeshenie = table.Column<int>(type: "int", nullable: false),
                    pomeshenieid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technikas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Technikas_Pomeshenies_pomeshenieid",
                        column: x => x.pomeshenieid,
                        principalTable: "Pomeshenies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Technikas_Sotrudnikis_sotrudnikiid",
                        column: x => x.sotrudnikiid,
                        principalTable: "Sotrudnikis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peremeshenies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_technika = table.Column<int>(type: "int", nullable: false),
                    technikaid = table.Column<int>(type: "int", nullable: true),
                    id_pomeshenie = table.Column<int>(type: "int", nullable: false),
                    pomeshenieid = table.Column<int>(type: "int", nullable: true),
                    data_ustanivki = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_demontazha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prichina = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peremeshenies", x => x.id);
                    table.ForeignKey(
                        name: "FK_Peremeshenies_Pomeshenies_pomeshenieid",
                        column: x => x.pomeshenieid,
                        principalTable: "Pomeshenies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Peremeshenies_Technikas_technikaid",
                        column: x => x.technikaid,
                        principalTable: "Technikas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_pomeshenieid",
                table: "Peremeshenies",
                column: "pomeshenieid");

            migrationBuilder.CreateIndex(
                name: "IX_Peremeshenies_technikaid",
                table: "Peremeshenies",
                column: "technikaid");

            migrationBuilder.CreateIndex(
                name: "IX_Rashod_Materials_materialid",
                table: "Rashod_Materials",
                column: "materialid");

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_pomeshenieid",
                table: "Technikas",
                column: "pomeshenieid");

            migrationBuilder.CreateIndex(
                name: "IX_Technikas_sotrudnikiid",
                table: "Technikas",
                column: "sotrudnikiid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peremeshenies");

            migrationBuilder.DropTable(
                name: "Rashod_Materials");

            migrationBuilder.DropTable(
                name: "Technikas");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Pomeshenies");

            migrationBuilder.DropTable(
                name: "Sotrudnikis");
        }
    }
}
