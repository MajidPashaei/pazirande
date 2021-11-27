using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class nn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tbl_Pazirandes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Tbl_Pazirandes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tbl_Pazirandes");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tbl_Pazirandes");
        }
    }
}
