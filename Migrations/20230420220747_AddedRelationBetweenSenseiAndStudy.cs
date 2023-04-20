using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFrelationsANDmigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationBetweenSenseiAndStudy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SenseiId",
                table: "Studies",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Studies_SenseiId",
                table: "Studies",
                column: "SenseiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studies_Senseis_SenseiId",
                table: "Studies",
                column: "SenseiId",
                principalTable: "Senseis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studies_Senseis_SenseiId",
                table: "Studies");

            migrationBuilder.DropIndex(
                name: "IX_Studies_SenseiId",
                table: "Studies");

            migrationBuilder.DropColumn(
                name: "SenseiId",
                table: "Studies");
        }
    }
}
