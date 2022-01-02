using Microsoft.EntityFrameworkCore.Migrations;

namespace Giris2.Migrations
{
    public partial class UserAndGenderRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_User_GenderId",
                table: "User",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Gender_GenderId",
                table: "User",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Gender_GenderId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_GenderId",
                table: "User");
        }
    }
}
