using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentVersionManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemperingHardnessHigh",
                table: "ModelVersions");

            migrationBuilder.DropColumn(
                name: "TemperingHardnessLow",
                table: "ModelVersions");

            migrationBuilder.AddColumn<int>(
                name: "TestCapacity",
                table: "ModelVersions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestCapacity",
                table: "ModelVersions");

            migrationBuilder.AddColumn<int>(
                name: "TemperingHardnessHigh",
                table: "ModelVersions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemperingHardnessLow",
                table: "ModelVersions",
                type: "int",
                nullable: true);
        }
    }
}
