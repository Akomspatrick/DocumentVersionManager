﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocumentVersionManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProcessFlowGroups",
                columns: table => new
                {
                    ProcessFlowGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessFlowGroups", x => x.ProcessFlowGroupName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelTypes",
                columns: table => new
                {
                    ModelTypeName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProcessFlowGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelTypes", x => x.ModelTypeName);
                    table.ForeignKey(
                        name: "FK_ModelTypes_ProcessFlowGroups_ProcessFlowGroupName",
                        column: x => x.ProcessFlowGroupName,
                        principalTable: "ProcessFlowGroups",
                        principalColumn: "ProcessFlowGroupName",
                        onDelete: ReferentialAction.Cascade);
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
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    TestCapacity = table.Column<int>(type: "int", nullable: false),
                    NominalOutput = table.Column<double>(type: "double", precision: 18, scale: 6, nullable: true),
                    NominalOutputPercentage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    NonlinearityPercentage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: true),
                    MinimumDeadLoad = table.Column<int>(type: "int", nullable: true),
                    vMin = table.Column<double>(type: "double", precision: 11, scale: 1, nullable: true),
                    nMax = table.Column<int>(type: "int", nullable: true),
                    SafeLoad = table.Column<int>(type: "int", nullable: true),
                    UltimateLoad = table.Column<int>(type: "int", nullable: true),
                    ShellMaterialName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultCableLength = table.Column<int>(type: "int", nullable: true),
                    Resistance = table.Column<int>(type: "int", nullable: true),
                    CCNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccuracyClass = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Application = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    Order = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_ModelTypes_ProcessFlowGroupName",
                table: "ModelTypes",
                column: "ProcessFlowGroupName");

            migrationBuilder.CreateIndex(
                name: "IX_ModelVersions_ModelName",
                table: "ModelVersions",
                column: "ModelName");
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
                name: "ModelTypes");

            migrationBuilder.DropTable(
                name: "ProcessFlowGroups");
        }
    }
}
