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
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<bool>("Alloy")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("CCNumber")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("DefaultCableLength")
                        .HasColumnType("int");

                    b.Property<string>("DefaultTestingMode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.Property<int>("MinimumDeadLoad")
                        .HasColumnType("int");

                    b.Property<string>("ModelVersionGroupName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("ModelVersionName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("NTEPCertificationId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("NTEPCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("NominalOutput")
                        .HasColumnType("double");

                    b.Property<decimal>("NominalOutputPercentage")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("NonlinearityPercentage")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("NumberOfGauges")
                        .HasColumnType("int");

                    b.Property<string>("OIMLCertificationId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("OIMLCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Resistance")
                        .HasColumnType("int");

                    b.Property<int>("SafeLoad")
                        .HasColumnType("int");

                    b.Property<string>("ShellMaterialName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("TemperingHardnessHigh")
                        .HasColumnType("int");

                    b.Property<int>("TemperingHardnessLow")
                        .HasColumnType("int");

                    b.Property<bool>("TestPointDirection")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UltimateLoad")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("VersionDescription")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)");

                    b.Property<int>("nMax")
                        .HasColumnType("int");

                    b.Property<double>("vMin")
                        .HasColumnType("double");

                    b.HasKey("ModelVersionId", "ModelName");

                    b.HasIndex("ModelName");

                    b.HasIndex("ModelVersionGroupName");

                    b.HasIndex("ShellMaterialName");

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

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersionGroup", b =>
                {
                    b.Property<string>("ModelVersionGroupName")
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

                    b.HasKey("ModelVersionGroupName");

                    b.ToTable("ModelVersionGroups");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BatcNo")
                        .HasColumnType("int");

                    b.Property<int>("CableLength")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("DefaultTestingMode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("GuidId")
                        .HasColumnType("char(36)");

                    b.Property<int>("InspectionResult")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("MachiningPurcharseOrderNo")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("ModelVersionGroupName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<int>("ModelVersionId")
                        .HasColumnType("int");

                    b.Property<string>("SalesOrderId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Stage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SteelPurcharseOrderNo")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("SubStage")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("ThermexPurcharseOrderNo")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UsedTestingMode")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("ProductId");

                    b.HasIndex("ModelVersionId", "ModelName");

                    b.ToTable("Products");
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

                    b.HasOne("DocumentVersionManager.Domain.Entities.ModelVersionGroup", "ModelVersionGroup")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ModelVersionGroupName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DocumentVersionManager.Domain.Entities.ShellMaterial", "ShellMaterial")
                        .WithMany("ModelVersions")
                        .HasForeignKey("ShellMaterialName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");

                    b.Navigation("ModelVersionGroup");

                    b.Navigation("ShellMaterial");
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

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.Product", b =>
                {
                    b.HasOne("DocumentVersionManager.Domain.Entities.ModelVersion", "ModelVersion")
                        .WithMany("Products")
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

                    b.Navigation("Products");

                    b.Navigation("TestPoints");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ModelVersionGroup", b =>
                {
                    b.Navigation("ModelVersions");
                });

            modelBuilder.Entity("DocumentVersionManager.Domain.Entities.ShellMaterial", b =>
                {
                    b.Navigation("ModelVersions");
                });
#pragma warning restore 612, 618
        }
    }
}
