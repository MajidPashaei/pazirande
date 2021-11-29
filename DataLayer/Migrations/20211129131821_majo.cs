using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class majo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameCreateUser",
                table: "Tbl_Pazirandes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_ClassCodess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(nullable: true),
                    ClassCode = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ClassCodess", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_ClassCodess");

            migrationBuilder.DropColumn(
                name: "NameCreateUser",
                table: "Tbl_Pazirandes");
        }
    }
}
