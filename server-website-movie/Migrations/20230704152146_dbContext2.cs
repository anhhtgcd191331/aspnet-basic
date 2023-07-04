using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server_website_movie.Migrations
{
    /// <inheritdoc />
    public partial class dbContext2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tests_TestId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TestId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserAccountId",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_UserAccountId",
                table: "Tests",
                column: "UserAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Users_UserAccountId",
                table: "Tests",
                column: "UserAccountId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Users_UserAccountId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_UserAccountId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "Tests");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_TestId",
                table: "Users",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tests_TestId",
                table: "Users",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
