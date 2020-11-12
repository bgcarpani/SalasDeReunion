using Microsoft.EntityFrameworkCore.Migrations;

namespace SalasDeReunion.Migrations
{
    public partial class ModifyReservas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AccesoInet",
                table: "Reservas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Pizarra",
                table: "Reservas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Proyector",
                table: "Reservas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccesoInet",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Pizarra",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "Proyector",
                table: "Reservas");
        }
    }
}
