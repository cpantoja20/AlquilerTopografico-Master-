using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    IdEquipo = table.Column<string>(nullable: false),
                    IdCliente = table.Column<int>(nullable: true),
                    Valor = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdCliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquilers");
        }
    }
}