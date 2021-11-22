using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class egegehegh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Tbl_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RCode",
                table: "Tbl_Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Tbl_Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_PazirandeUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(nullable: true),
                    Customer_Number = table.Column<string>(nullable: true),
                    Customer_Group = table.Column<string>(nullable: true),
                    Customer_Type = table.Column<string>(nullable: true),
                    Customer_National = table.Column<string>(nullable: true),
                    Name_fa = table.Column<string>(nullable: true),
                    Name_en = table.Column<string>(nullable: true),
                    Family_fa = table.Column<string>(nullable: true),
                    Family_en = table.Column<string>(nullable: true),
                    FatherName_fa = table.Column<string>(nullable: true),
                    FatherName_en = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    National_Code = table.Column<string>(nullable: true),
                    Certificate_Code = table.Column<string>(nullable: true),
                    Certificate_Serial = table.Column<string>(nullable: true),
                    Certificate_NumSerial = table.Column<string>(nullable: true),
                    Certificate_Letters = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Birth_Place = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Phone_Code = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    Company_Id = table.Column<string>(nullable: true),
                    Establishing_Date = table.Column<DateTime>(nullable: false),
                    CompanyName_fa = table.Column<string>(nullable: true),
                    CompanyName_en = table.Column<string>(nullable: true),
                    Brand_Name = table.Column<string>(nullable: true),
                    Company_Registration = table.Column<string>(nullable: true),
                    Economic_Code = table.Column<string>(nullable: true),
                    Comprehensive_Code = table.Column<string>(nullable: true),
                    Passport_Code = table.Column<string>(nullable: true),
                    Passport_Validity = table.Column<DateTime>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    nationalcard_image1 = table.Column<string>(nullable: true),
                    nationalcard_image2 = table.Column<string>(nullable: true),
                    certificate_image = table.Column<string>(nullable: true),
                    newspaper_image = table.Column<string>(nullable: true),
                    statute_image = table.Column<string>(nullable: true),
                    establishment_image = table.Column<string>(nullable: true),
                    passport_image = table.Column<string>(nullable: true),
                    arrangementcard_image = table.Column<string>(nullable: true),
                    workpermit_image = table.Column<string>(nullable: true),
                    Set_Date = table.Column<DateTime>(nullable: false),
                    setdate = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_PazirandeUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_PazirandeUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Tbl_Users");

            migrationBuilder.DropColumn(
                name: "RCode",
                table: "Tbl_Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Tbl_Users");
        }
    }
}
