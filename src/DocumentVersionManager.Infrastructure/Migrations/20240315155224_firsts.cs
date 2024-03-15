using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentVersionManager.Infrastructure.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:src/DocumentVersionManager.Infrastructure/Migrations/20240315155224_firsts.cs
    public partial class firsts : Migration
========
    public partial class testings : Migration
>>>>>>>> parent of 1e8c4a3 (added drivepath and doc name back to modelversion doc):src/DocumentVersionManager.Infrastructure/Migrations/20240309233744_testings.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelTypes",
                columns: table => new
                {
                    ModelTypeName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelTypes", x => x.ModelTypeName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShellMaterials",
                columns: table => new
                {
                    ShellMaterialName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alloy = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShellMaterials", x => x.ShellMaterialName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TestingModeGroups",
                columns: table => new
                {
                    TestingModeGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestingModeGroups", x => x.TestingModeGroupName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelTypeName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelName);
                    table.ForeignKey(
                        name: "FK_Models_ModelTypes_ModelTypeName",
                        column: x => x.ModelTypeName,
                        principalTable: "ModelTypes",
                        principalColumn: "ModelTypeName",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelVersions",
                columns: table => new
                {
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VersionDescription = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelVersionName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TestingModeGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    NominalOutput = table.Column<double>(type: "double", nullable: false),
                    NominalOutputPercentage = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    NonlinearityPercentage = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MinimumDeadLoad = table.Column<int>(type: "int", nullable: false),
                    vMin = table.Column<double>(type: "double", nullable: false),
                    nMax = table.Column<int>(type: "int", nullable: false),
                    SafeLoad = table.Column<int>(type: "int", nullable: false),
                    UltimateLoad = table.Column<int>(type: "int", nullable: false),
                    ShellMaterialName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alloy = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DefaultCableLength = table.Column<int>(type: "int", nullable: false),
                    NumberOfGauges = table.Column<int>(type: "int", nullable: false),
                    Resistance = table.Column<int>(type: "int", nullable: false),
                    CCNumber = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccuracyClass = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Application = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TemperingHardnessLow = table.Column<int>(type: "int", nullable: false),
                    TemperingHardnessHigh = table.Column<int>(type: "int", nullable: false),
                    NTEPCertificationId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NTEPCertificationTimestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    OIMLCertificationId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OIMLCertificationTimestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TestPointDirection = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelVersions", x => new { x.ModelVersionId, x.ModelName });
                    table.ForeignKey(
                        name: "FK_ModelVersions_Models_ModelName",
                        column: x => x.ModelName,
                        principalTable: "Models",
                        principalColumn: "ModelName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelVersions_ShellMaterials_ShellMaterialName",
                        column: x => x.ShellMaterialName,
                        principalTable: "ShellMaterials",
                        principalColumn: "ShellMaterialName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelVersions_TestingModeGroups_TestingModeGroupName",
                        column: x => x.TestingModeGroupName,
                        principalTable: "TestingModeGroups",
                        principalColumn: "TestingModeGroupName",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelVersionDocuments",
                columns: table => new
                {
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelVersionDocumentId = table.Column<int>(type: "int", nullable: false),
                    DocumentDescription = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentDrive = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentPath = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocumentGuid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Documentname = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelVersionDocuments", x => new { x.ModelVersionId, x.ModelName, x.ModelVersionDocumentId });
                    table.ForeignKey(
                        name: "FK_ModelVersionDocuments_ModelVersions_ModelVersionId_ModelName",
                        columns: x => new { x.ModelVersionId, x.ModelName },
                        principalTable: "ModelVersions",
                        principalColumns: new[] { "ModelVersionId", "ModelName" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TestPoints",
                columns: table => new
                {
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CapacityTestPoint = table.Column<int>(type: "int", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPoints", x => new { x.ModelVersionId, x.ModelName, x.CapacityTestPoint });
                    table.ForeignKey(
                        name: "FK_TestPoints_ModelVersions_ModelVersionId_ModelName",
                        columns: x => new { x.ModelVersionId, x.ModelName },
                        principalTable: "ModelVersions",
                        principalColumns: new[] { "ModelVersionId", "ModelName" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Models_ModelTypeName",
                table: "Models",
                column: "ModelTypeName");

            migrationBuilder.CreateIndex(
                name: "IX_ModelVersions_ModelName",
                table: "ModelVersions",
                column: "ModelName");

            migrationBuilder.CreateIndex(
                name: "IX_ModelVersions_ShellMaterialName",
                table: "ModelVersions",
                column: "ShellMaterialName");

            migrationBuilder.CreateIndex(
                name: "IX_ModelVersions_TestingModeGroupName",
                table: "ModelVersions",
                column: "TestingModeGroupName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelVersionDocuments");

            migrationBuilder.DropTable(
                name: "TestPoints");

            migrationBuilder.DropTable(
                name: "ModelVersions");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "ShellMaterials");

            migrationBuilder.DropTable(
                name: "TestingModeGroups");

            migrationBuilder.DropTable(
                name: "ModelTypes");
        }
    }
}
