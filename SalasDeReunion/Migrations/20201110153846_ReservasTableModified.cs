using Microsoft.EntityFrameworkCore.Migrations;

namespace SalasDeReunion.Migrations
{
    public partial class ReservasTableModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoReservacion",
                table: "Reservas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoReservacion",
                table: "Reservas");
        }
    }
}
