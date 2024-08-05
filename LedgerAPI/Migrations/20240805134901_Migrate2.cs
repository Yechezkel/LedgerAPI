using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LedgerAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LedgerId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ledger",
                columns: table => new
                {
                    LedgerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledger", x => x.LedgerId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_LedgerId",
                table: "User",
                column: "LedgerId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Ledger_LedgerId",
                table: "User",
                column: "LedgerId",
                principalTable: "Ledger",
                principalColumn: "LedgerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Ledger_LedgerId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Ledger");

            migrationBuilder.DropIndex(
                name: "IX_User_LedgerId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LedgerId",
                table: "User");
        }
    }
}
