using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalasDeReunion.Migrations
{
    public partial class AddCantidadDeGenteToReservas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaId = table.Column<int>(nullable: false),
                    HoraInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    HoraFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    NombreReserva = table.Column<string>(maxLength: 50, nullable: false),
                    CantidadDeGente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservasId);
                });

        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservas");

        }
    }
}
