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
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DocumentVersionManager.Infrastructure.Persistence.Repositories.Models.CapacityDocument", b =>
                {
                    b.Property<int>("Capacity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DocumentPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Capacity");

                    b.ToTable("CapacityDocument");
                });

            modelBuilder.Entity("DocumentVersionManager.Infrastructure.Persistence.Repositories.Models.CapacitySpecification", b =>
                {
                    b.Property<int>("Capacity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Alloy")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Application")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("AustenitizationHardnessHigh")
                        .HasColumnType("int");

                    b.Property<int?>("AustenitizationHardnessLow")
                        .HasColumnType("int");

                    b.Property<double?>("AustenitizationTemperatureInF")
                        .HasColumnType("double");

                    b.Property<int?>("AustenitizationTimeInSeconds")
                        .HasColumnType("int");

                    b.Property<string>("CCNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("DefaultCableLength")
                        .HasColumnType("int");

                    b.Property<bool>("HasScrews")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("MinimumDeadLoad")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NTEPCertificationId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("NTEPCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("NominalOutput")
                        .HasColumnType("double");

                    b.Property<decimal?>("NominalOutputPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NonlinearityPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("NumberInBasket")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfGauges")
                        .HasColumnType("int");

                    b.Property<string>("OIMLCertificationId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("OIMLCertificationTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Resistance")
                        .HasColumnType("int");

                    b.Property<int?>("SafeLoad")
                        .HasColumnType("int");

                    b.Property<string>("ShellMaterial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("TempRangeHigh")
                        .HasColumnType("int");

                    b.Property<int?>("TempRangeLow")
                        .HasColumnType("int");

                    b.Property<int?>("TemperingHardnessHigh")
                        .HasColumnType("int");

                    b.Property<int?>("TemperingHardnessLow")
                        .HasColumnType("int");

                    b.Property<double?>("TemperingTemperatureInF")
                        .HasColumnType("double");

                    b.Property<int?>("TemperingTimeInSeconds")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UltimateLoad")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("nMax")
                        .HasColumnType("int");

                    b.Property<double?>("vMin")
                        .HasColumnType("double");

                    b.HasKey("Capacity");

                    b.ToTable("CapacitySpecification");
                });

            modelBuilder.Entity("DocumentVersionManager.Infrastructure.Persistence.Repositories.Models.Model", b =>
                {
                    b.Property<string>("ModelName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ModelTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ModelName");

                    b.ToTable("Model");
                });
#pragma warning restore 612, 618
        }
    }
}
