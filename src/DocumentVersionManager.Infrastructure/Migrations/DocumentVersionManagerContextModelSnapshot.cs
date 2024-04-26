﻿// <auto-generated />
using System;
using DocumentVersionManager.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DocumentVersionManager.Infrastructure.Migrations
{
    [DbContext(typeof(DocumentVersionManagerContext))]
    partial class DocumentVersionManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.Model", b =>
                {
                    b.Property<string>("ModelName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ModelTypeName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("ModelName");

                    b.HasIndex("ModelTypeName");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelType", b =>
                {
                    b.Property<string>("ModelTypeName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.HasKey("ModelTypeName");

                    b.ToTable("ModelTypes");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersion", b =>
                {
                    b.Property<int>("ModelVersionId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("AccuracyClass")
                        .HasColumnType("longtext");

                    b.Property<bool>("Alloy")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Application")
                        .HasColumnType("longtext");

                    b.Property<string>("CCNumber")
                        .HasColumnType("longtext");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("DefaultCableLength")
                        .HasColumnType("int");

                    b.Property<string>("DefaultTestingMode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.Property<int?>("MinimumDeadLoad")
                        .HasColumnType("int");

                    b.Property<string>("ModelVersionName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("NTEPCertificationId")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("NTEPCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("NominalOutput")
                        .HasPrecision(18, 6)
                        .HasColumnType("double");

                    b.Property<decimal?>("NominalOutputPercentage")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<decimal?>("NonlinearityPercentage")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<int?>("NumberOfGauges")
                        .HasColumnType("int");

                    b.Property<string>("OIMLCertificationId")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("OIMLCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Resistance")
                        .HasColumnType("int");

                    b.Property<int?>("SafeLoad")
                        .HasColumnType("int");

                    b.Property<string>("ShellMaterialName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int?>("TemperingHardnessHigh")
                        .HasColumnType("int");

                    b.Property<int?>("TemperingHardnessLow")
                        .HasColumnType("int");

                    b.Property<bool>("TestPointDirection")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProcessFlowGroupName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UltimateLoad")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("VersionDescription")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)");

                    b.Property<int?>("nMax")
                        .HasColumnType("int");

                    b.Property<double?>("vMin")
                        .HasPrecision(11, 1)
                        .HasColumnType("double");

                    b.HasKey("ModelVersionId", "ModelName");

                    b.HasIndex("ModelName");

                    b.HasIndex("ShellMaterialName");

                    b.HasIndex("ProcessFlowGroupName");

                    b.ToTable("ModelVersions");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersionDocument", b =>
                {
                    b.Property<int>("ModelVersionId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("ModelVersionDocumentId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentDescription")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DocumentDrive")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("DocumentGuid")
                        .HasColumnType("char(36)");

                    b.Property<string>("DocumentPath")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Documentname")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("ModelVersionId", "ModelName", "ModelVersionDocumentId");

                    b.ToTable("ModelVersionDocuments");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ShellMaterial", b =>
                {
                    b.Property<string>("ShellMaterialName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<bool>("Alloy")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.HasKey("ShellMaterialName");

                    b.ToTable("ShellMaterials");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.TestPoint", b =>
                {
                    b.Property<int>("ModelVersionId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("CapacityTestPoint")
                        .HasColumnType("int");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.HasKey("ModelVersionId", "ModelName", "CapacityTestPoint");

                    b.ToTable("TestPoints");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ProcessFlowGroup", b =>
                {
                    b.Property<string>("ProcessFlowGroupName")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DefaultTestingMode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.HasKey("ProcessFlowGroupName");

                    b.ToTable("ProcessFlowGroups");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.Model", b =>
                {
                    b.HasOne("DocumentVersionManager.Domain.Entities.ModelType", "ModelType")
                        .WithMany("Models")
                        .HasForeignKey("ModelTypeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelType");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersion", b =>
                {
                    b.HasOne("DocumentVersionManager.Domain.Entities.Model", "Model")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ModelName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentVersionManager.Domain.Entities.ShellMaterial", "ShellMaterial")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ShellMaterialName");

                    b.HasOne("DocumentVersionManager.Domain.Entities.ProcessFlowGroup", "ProcessFlowGroup")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ProcessFlowGroupName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");

                    b.Navigation("ShellMaterial");

                    b.Navigation("ProcessFlowGroup");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersionDocument", b =>
                {
                    b.HasOne("DocumentVersionManager.Domain.Entities.ModelVersion", "ModelVersion")
                        .WithMany("ModelVersionDocuments")
                        .HasForeignKey("ModelVersionId", "ModelName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelVersion");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.TestPoint", b =>
                {
                    b.HasOne("DocumentVersionManager.Domain.Entities.ModelVersion", "ModelVersion")
                        .WithMany("TestPoints")
                        .HasForeignKey("ModelVersionId", "ModelName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelVersion");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.Model", b =>
                {
                    b.Navigation("ModelVersions");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelType", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersion", b =>
                {
                    b.Navigation("ModelVersionDocuments");

                    b.Navigation("TestPoints");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ShellMaterial", b =>
                {
                    b.Navigation("ModelVersions");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ProcessFlowGroup", b =>
                {
                    b.Navigation("ModelVersions");
                });
#pragma warning restore 612, 618
        }
    }
}
