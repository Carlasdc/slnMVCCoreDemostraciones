using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPasajeros.Migrations
{
    public partial class CrearBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pasajeros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Ciudad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasajeros", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pasajeros",
                columns: new[] { "Id", "Apellido", "Ciudad", "FechaNacimiento", "Nombre" },
                values: new object[] { 1, "Brewer", "Ocala", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(30), "Tara" });

            migrationBuilder.InsertData(
                table: "Pasajeros",
                columns: new[] { "Id", "Apellido", "Ciudad", "FechaNacimiento", "Nombre" },
                values: new object[] { 2, "Tippett", "Anaheim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(27), "Andrew" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pasajeros");
        }
    }
}
