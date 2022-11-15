using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eah.WorkSafety.WebApp.Back.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RiskAssessment_Users_UserId",
                table: "RiskAssessment");

            migrationBuilder.DropColumn(
                name: "IdentifierUserId",
                table: "RiskAssessment");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "RiskAssessment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskAssessment_Users_UserId",
                table: "RiskAssessment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RiskAssessment_Users_UserId",
                table: "RiskAssessment");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "RiskAssessment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdentifierUserId",
                table: "RiskAssessment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskAssessment_Users_UserId",
                table: "RiskAssessment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
