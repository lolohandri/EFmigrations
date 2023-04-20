using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFrelationsANDmigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedMentorBoolField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMentor",
                table: "Students",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMentor",
                table: "Students");
        }
    }
}
