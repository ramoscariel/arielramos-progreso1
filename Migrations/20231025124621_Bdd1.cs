using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace arielramos_progreso1.Migrations
{
    public partial class Bdd1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArielRamos_Tabla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArPesoKilogramos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArAlturaM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArNombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ArEmpleado = table.Column<bool>(type: "bit", nullable: false),
                    ArFechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArielRamos_Tabla", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArielRamos_Tabla");
        }
    }
}
