using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class mohsen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Pazirandes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Type_Moshtari = table.Column<string>(nullable: true),
                    Code_Meli = table.Column<string>(nullable: true),
                    Shenase_Meli = table.Column<string>(nullable: true),
                    Shomare_Shenasname = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Family = table.Column<string>(nullable: true),
                    Tarikh_Tavalod = table.Column<DateTime>(nullable: false),
                    Name_Pedar = table.Column<string>(nullable: true),
                    Jensiat = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Name_EN = table.Column<string>(nullable: true),
                    Family_EN = table.Column<string>(nullable: true),
                    Pedar_EN = table.Column<string>(nullable: true),
                    Name_Sherkat = table.Column<string>(nullable: true),
                    Tarikh_Tasis_sherkat = table.Column<DateTime>(nullable: false),
                    Name_EN_Sherkat = table.Column<string>(nullable: true),
                    Code_Egtesadi = table.Column<string>(nullable: true),
                    Name_Tejari = table.Column<string>(nullable: true),
                    Shomare_Sabt = table.Column<string>(nullable: true),
                    Pazirande_Atba = table.Column<bool>(nullable: false),
                    Code_Faragir = table.Column<string>(nullable: true),
                    Code_Gozarname = table.Column<string>(nullable: true),
                    Tarikh_Etbar = table.Column<DateTime>(nullable: false),
                    Melyat = table.Column<string>(nullable: true),
                    Shenase_Onvan_Nemayandegi = table.Column<string>(nullable: true),
                    Shenase_Bazaryab_Nemayandegi = table.Column<string>(nullable: true),
                    Shenase_Porojeh = table.Column<string>(nullable: true),
                    Shenase_Switch = table.Column<string>(nullable: true),
                    Shenase_Type_Dargah = table.Column<string>(nullable: true),
                    Shenase_Type_Dastgah = table.Column<string>(nullable: true),
                    Shenase_Model_Dastgah = table.Column<string>(nullable: true),
                    Shenase_Bank = table.Column<string>(nullable: true),
                    Code_Shobe = table.Column<string>(nullable: true),
                    Shomare_Hesab = table.Column<string>(nullable: true),
                    Shomare_Sheba = table.Column<string>(nullable: true),
                    Code_Shaparaki_shahr = table.Column<string>(nullable: true),
                    Mantage_Shahri = table.Column<string>(nullable: true),
                    Code_Posti = table.Column<string>(nullable: true),
                    TelePhone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Code_Takmily_Senf = table.Column<string>(nullable: true),
                    Onvan_Mahal_Kasb = table.Column<string>(nullable: true),
                    Onvan_Latin_Kasb = table.Column<string>(nullable: true),
                    Shenase_Malekyat = table.Column<string>(nullable: true),
                    Address_Shaparaki = table.Column<string>(nullable: true),
                    Address_Latin = table.Column<string>(nullable: true),
                    Shenase_Mahal_kasb = table.Column<string>(nullable: true),
                    Shomare_Javaz_kasb = table.Column<string>(nullable: true),
                    Marja_Saderkonande_Mojavez = table.Column<string>(nullable: true),
                    Tarikh_Sodor_Javaz = table.Column<DateTime>(nullable: false),
                    Tarikh_Payan_Etebar = table.Column<DateTime>(nullable: false),
                    Shomare_Garardad_Ejare = table.Column<string>(nullable: true),
                    Tarikh_Etmam_Ejare = table.Column<DateTime>(nullable: false),
                    Code_Rahgiri = table.Column<string>(nullable: true),
                    Type_Garardad_Hesab = table.Column<string>(nullable: true),
                    Shenase_Type_Vagozari = table.Column<string>(nullable: true),
                    Type_Vadieh = table.Column<string>(nullable: true),
                    Shomare_Sanad = table.Column<string>(nullable: true),
                    Mablag_Frosh = table.Column<string>(nullable: true),
                    Moaref = table.Column<string>(nullable: true),
                    Phone_Moaref = table.Column<string>(nullable: true),
                    Tedad_Agsat = table.Column<string>(nullable: true),
                    Mablag_Agsat = table.Column<string>(nullable: true),
                    Mobail_Motasel = table.Column<string>(nullable: true),
                    Name_Fani_Pos = table.Column<string>(nullable: true),
                    Mobaile_Fani_Pos = table.Column<string>(nullable: true),
                    Telephone_Fani_Pos = table.Column<string>(nullable: true),
                    Shomare_Pazirande = table.Column<string>(nullable: true),
                    Shomare_Terminal = table.Column<string>(nullable: true),
                    Serial_Dastgah = table.Column<string>(nullable: true),
                    Tarikh_Nasb = table.Column<DateTime>(nullable: false),
                    Shomare_Marja = table.Column<string>(nullable: true),
                    Tarikh_Tarif_Switch = table.Column<DateTime>(nullable: false),
                    Tarikh_Tarif_Shaparak = table.Column<DateTime>(nullable: false),
                    Nemad_Elektroniki = table.Column<string>(nullable: true),
                    Tarikh_Etmam_Etebar = table.Column<DateTime>(nullable: false),
                    Tarikh_Sodor_Nemad = table.Column<DateTime>(nullable: false),
                    Type_Nemad = table.Column<string>(nullable: true),
                    Server_Frosh = table.Column<string>(nullable: true),
                    IPGAccessPort = table.Column<string>(nullable: true),
                    IPGCallBackAddress = table.Column<string>(nullable: true),
                    Address_Post_Sherkat = table.Column<string>(nullable: true),
                    Mahsolat_Frosh = table.Column<string>(nullable: true),
                    Address_Post = table.Column<string>(nullable: true),
                    Family_Masol_Fani = table.Column<string>(nullable: true),
                    Mobail_Masol_Fani = table.Column<string>(nullable: true),
                    Name_Fani_Masol_Fani = table.Column<string>(nullable: true),
                    Code_Meli_Masol_Fani = table.Column<string>(nullable: true),
                    Address_Site = table.Column<string>(nullable: true),
                    Emkan_Lagv = table.Column<string>(nullable: true),
                    Zamine_Faliat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Pazirandes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Pazirandes");
        }
    }
}
