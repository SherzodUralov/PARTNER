using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PARTNER.Migrations
{
    public partial class InitalCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interists",
                columns: table => new
                {
                    InteristId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Music = table.Column<int>(type: "int", nullable: true),
                    Art = table.Column<int>(type: "int", nullable: true),
                    Sport = table.Column<int>(type: "int", nullable: true),
                    Scientific = table.Column<int>(type: "int", nullable: true),
                    BoshqaSoxa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interists", x => x.InteristId);
                });

            migrationBuilder.CreateTable(
                name: "Nogirons",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NogironName = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Typeee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nogirons", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Districts_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unversties",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    UnverstyName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unversties", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Unversties_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LiveReadies",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Mahalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    LiveType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveReadies", x => x.Code);
                    table.ForeignKey(
                        name: "FK_LiveReadies_Districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "Districts",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentsType = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SureName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNamber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TelegramNamber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    NogironCode = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Mahalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentsId);
                    table.ForeignKey(
                        name: "FK_Parents_Districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "Districts",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parents_Nogirons_NogironCode",
                        column: x => x.NogironCode,
                        principalTable: "Nogirons",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parents_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tyutors",
                columns: table => new
                {
                    TyutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SureName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    Staj = table.Column<int>(type: "int", nullable: false),
                    MobileNamber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelegramNamber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Degree = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tyutors", x => x.TyutorId);
                    table.ForeignKey(
                        name: "FK_Tyutors_Districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "Districts",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tyutors_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    FacultyName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UnverstyCode = table.Column<string>(type: "nvarchar(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Faculties_Unversties_UnverstyCode",
                        column: x => x.UnverstyCode,
                        principalTable: "Unversties",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(7)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Branches_Faculties_FacultyCode",
                        column: x => x.FacultyCode,
                        principalTable: "Faculties",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    TyutorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Groups_Branches_BranchCode",
                        column: x => x.BranchCode,
                        principalTable: "Branches",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Groups_Tyutors_TyutorId",
                        column: x => x.TyutorId,
                        principalTable: "Tyutors",
                        principalColumn: "TyutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SureName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    MobileNamber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TelegramNamber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nation = table.Column<int>(type: "int", nullable: true),
                    ParentsId = table.Column<int>(type: "int", nullable: false),
                    InteristId = table.Column<int>(type: "int", nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    DistrictCode = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    Mahalla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnverstyCode = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    FacultyCode = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    BranchCode = table.Column<string>(type: "nvarchar(7)", nullable: true),
                    GroupCode = table.Column<string>(type: "nvarchar(6)", nullable: true),
                    Cours = table.Column<int>(type: "int", nullable: false),
                    LiveReadyCode = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Contract = table.Column<int>(type: "int", nullable: true),
                    Familly = table.Column<int>(type: "int", nullable: true),
                    KamTam = table.Column<int>(type: "int", nullable: true),
                    Boquvchi = table.Column<int>(type: "int", nullable: true),
                    NogironCode = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    Degree = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Branches_BranchCode",
                        column: x => x.BranchCode,
                        principalTable: "Branches",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Districts_DistrictCode",
                        column: x => x.DistrictCode,
                        principalTable: "Districts",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyCode",
                        column: x => x.FacultyCode,
                        principalTable: "Faculties",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Groups_GroupCode",
                        column: x => x.GroupCode,
                        principalTable: "Groups",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Interists_InteristId",
                        column: x => x.InteristId,
                        principalTable: "Interists",
                        principalColumn: "InteristId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_LiveReadies_LiveReadyCode",
                        column: x => x.LiveReadyCode,
                        principalTable: "LiveReadies",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Nogirons_NogironCode",
                        column: x => x.NogironCode,
                        principalTable: "Nogirons",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Parents",
                        principalColumn: "ParentsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Regions_RegionCode",
                        column: x => x.RegionCode,
                        principalTable: "Regions",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Unversties_UnverstyCode",
                        column: x => x.UnverstyCode,
                        principalTable: "Unversties",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CHECK",
                columns: table => new
                {
                    CheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearMonth = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    Timee = table.Column<int>(type: "int", nullable: false),
                    Uzlashtirish = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHECK", x => x.CheckId);
                    table.ForeignKey(
                        name: "FK_CHECK_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_FacultyCode",
                table: "Branches",
                column: "FacultyCode");

            migrationBuilder.CreateIndex(
                name: "IX_CHECK_StudentId",
                table: "CHECK",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_RegionCode",
                table: "Districts",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_UnverstyCode",
                table: "Faculties",
                column: "UnverstyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_BranchCode",
                table: "Groups",
                column: "BranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TyutorId",
                table: "Groups",
                column: "TyutorId");

            migrationBuilder.CreateIndex(
                name: "IX_LiveReadies_DistrictCode",
                table: "LiveReadies",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_DistrictCode",
                table: "Parents",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_NogironCode",
                table: "Parents",
                column: "NogironCode");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_RegionCode",
                table: "Parents",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BranchCode",
                table: "Students",
                column: "BranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DistrictCode",
                table: "Students",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyCode",
                table: "Students",
                column: "FacultyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GroupCode",
                table: "Students",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_InteristId",
                table: "Students",
                column: "InteristId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LiveReadyCode",
                table: "Students",
                column: "LiveReadyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_NogironCode",
                table: "Students",
                column: "NogironCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentsId",
                table: "Students",
                column: "ParentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_RegionCode",
                table: "Students",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UnverstyCode",
                table: "Students",
                column: "UnverstyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Tyutors_DistrictCode",
                table: "Tyutors",
                column: "DistrictCode");

            migrationBuilder.CreateIndex(
                name: "IX_Tyutors_RegionCode",
                table: "Tyutors",
                column: "RegionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Unversties_RegionCode",
                table: "Unversties",
                column: "RegionCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CHECK");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Interists");

            migrationBuilder.DropTable(
                name: "LiveReadies");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Tyutors");

            migrationBuilder.DropTable(
                name: "Nogirons");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Unversties");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
