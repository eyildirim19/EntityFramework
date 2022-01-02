using Microsoft.EntityFrameworkCore.Migrations;

namespace Convestion_DataAnotations.Migrations
{
    public partial class CategoryAndProductRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KatID",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KatID",
                table: "Urun",
                column: "KatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Category_KatID",
                table: "Urun",
                column: "KatID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Category_KatID",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_KatID",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "KatID",
                table: "Urun");
        }
    }
}
