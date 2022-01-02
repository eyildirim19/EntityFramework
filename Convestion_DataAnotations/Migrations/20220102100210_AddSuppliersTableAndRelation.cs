using Microsoft.EntityFrameworkCore.Migrations;

namespace Convestion_DataAnotations.Migrations
{
    public partial class AddSuppliersTableAndRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierID",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContanctTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urun_SupplierID",
                table: "Urun",
                column: "SupplierID");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Suppliers_SupplierID",
                table: "Urun",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Suppliers_SupplierID",
                table: "Urun");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Urun_SupplierID",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "SupplierID",
                table: "Urun");
        }
    }
}
