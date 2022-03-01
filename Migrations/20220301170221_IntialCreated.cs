using Microsoft.EntityFrameworkCore.Migrations;

namespace PARTNER.Migrations
{
    public partial class IntialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentsId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ParentsId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentsId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Parents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Parents_StudentId",
                table: "Parents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Students_StudentId",
                table: "Parents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Students_StudentId",
                table: "Parents");

            migrationBuilder.DropIndex(
                name: "IX_Parents_StudentId",
                table: "Parents");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Parents");

            migrationBuilder.AddColumn<int>(
                name: "ParentsId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentsId",
                table: "Students",
                column: "ParentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentsId",
                table: "Students",
                column: "ParentsId",
                principalTable: "Parents",
                principalColumn: "ParentsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
