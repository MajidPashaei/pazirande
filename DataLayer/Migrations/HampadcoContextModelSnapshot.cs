﻿// <auto-generated />
using System;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(HampadcoContext))]
    partial class HampadcoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.Portal.Tbl_Pazirande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_Latin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_Post")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_Post_Sherkat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_Shaparaki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Egtesadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Faragir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Gozarname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Meli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Meli_Masol_Fani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Posti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Rahgiri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Shaparaki_shahr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Shobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code_Takmily_Senf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emkan_Lagv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family_Masol_Fani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPGAccessPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IPGCallBackAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jensiat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mablag_Agsat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mablag_Frosh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahsolat_Frosh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mantage_Shahri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marja_Saderkonande_Mojavez")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Melyat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Moaref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobail_Masol_Fani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobail_Motasel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobaile_Fani_Pos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_EN_Sherkat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Fani_Masol_Fani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Fani_Pos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Pedar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Sherkat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_Tejari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nemad_Elektroniki")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Onvan_Latin_Kasb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Onvan_Mahal_Kasb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pazirande_Atba")
                        .HasColumnType("bit");

                    b.Property<string>("Pedar_EN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Moaref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial_Dastgah")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Server_Frosh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Bank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Bazaryab_Nemayandegi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Mahal_kasb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Malekyat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Meli")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Model_Dastgah")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Onvan_Nemayandegi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Porojeh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Switch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Type_Dargah")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Type_Dastgah")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shenase_Type_Vagozari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Garardad_Ejare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Hesab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Javaz_kasb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Marja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Pazirande")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Sabt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Sanad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Sheba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Shenasname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shomare_Terminal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarikh_Etbar")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Etmam_Ejare")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Etmam_Etebar")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Nasb")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Payan_Etebar")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Sodor_Javaz")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Sodor_Nemad")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Tarif_Shaparak")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Tarif_Switch")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Tasis_sherkat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tarikh_Tavalod")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tedad_Agsat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone_Fani_Pos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Garardad_Hesab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Moshtari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Nemad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Vadieh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zamine_Faliat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Pazirandes");
                });

            modelBuilder.Entity("DataLayer.Entities.Portal.Tbl_PazirandeUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Birth_Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate_Letters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate_NumSerial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certificate_Serial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName_fa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company_Registration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comprehensive_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_National")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Economic_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Establishing_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Family_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family_fa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName_fa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_fa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("National_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Passport_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Passport_Validity")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Post")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Set_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arrangementcard_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("certificate_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("establishment_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalcard_image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalcard_image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("newspaper_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passport_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("setdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statute_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workpermit_image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_PazirandeUsers");
                });

            modelBuilder.Entity("DataLayer.Entities.Portal.Tbl_Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Supports");
                });

            modelBuilder.Entity("DataLayer.Entities.Tbl_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Users");
                });
#pragma warning restore 612, 618
        }
    }
}
