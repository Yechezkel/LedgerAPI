using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LedgerAPI.Migrations
{
    /// <inheritdoc />
    public partial class Migrate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Ledger_LedgerId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_LedgerId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LedgerId",
                table: "User");

            migrationBuilder.CreateTable(
                name: "LedgerUser",
                columns: table => new
                {
                    LedgersLedgerId = table.Column<int>(type: "int", nullable: false),
                    MembersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LedgerUser", x => new { x.LedgersLedgerId, x.MembersUserId });
                    table.ForeignKey(
                        name: "FK_LedgerUser_Ledger_LedgersLedgerId",
                        column: x => x.LedgersLedgerId,
                        principalTable: "Ledger",
                        principalColumn: "LedgerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LedgerUser_User_MembersUserId",
                        column: x => x.MembersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LedgerUser_MembersUserId",
                table: "LedgerUser",
                column: "MembersUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LedgerUser");

            migrationBuilder.AddColumn<int>(
                name: "LedgerId",
                table: "User",
                type: "int",
                nullable: true);

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
    }
}
