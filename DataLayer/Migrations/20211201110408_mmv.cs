using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class mmv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Document_Esteshhad",
                table: "Tbl_PazirandeUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Document_Garadad",
                table: "Tbl_PazirandeUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Document_Masdig",
                table: "Tbl_PazirandeUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Document_Soratjalase",
                table: "Tbl_PazirandeUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document_Esteshhad",
                table: "Tbl_PazirandeUsers");

            migrationBuilder.DropColumn(
                name: "Document_Garadad",
                table: "Tbl_PazirandeUsers");

            migrationBuilder.DropColumn(
                name: "Document_Masdig",
                table: "Tbl_PazirandeUsers");

            migrationBuilder.DropColumn(
                name: "Document_Soratjalase",
                table: "Tbl_PazirandeUsers");
        }
    }
}
