﻿using DocumentVersionManager.Domain.Constants;
using DocumentVersionManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ModelTypeConfig : IEntityTypeConfiguration<ModelType>
    {
        public void Configure(EntityTypeBuilder<ModelType> entity)
        {
            entity.HasKey(e => e.ModelTypeName);
            entity.Property(e => e.ModelTypeName).IsRequired().HasMaxLength(FixedValues.modelTypesNameMaxLength);

            //

            entity.HasData(ModelType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELTYPE"),
                           ModelType.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "SECONDMODELTYPE"),
                           ModelType.Create(Guid.Parse("3c69923e-a68e-4348-b06c-7007f527355d"), "THIRDMODELTYPE"));
        }
    }
    public class ModelConfig : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> entity)
        {
            entity.HasKey(e => new { e.ModelName });
            entity.Property(e => e.ModelName).HasMaxLength(FixedValues.ModelNameMaxLength);

            entity.Property(e => e.ModelTypeName).IsRequired().HasMaxLength(FixedValues.modelTypesNameMaxLength);//This has specified the foreign key
            entity.HasOne<ModelType>(e => e.ModelTypes).WithMany(ad => ad.Models).HasForeignKey(e => e.ModelTypeName);
            entity.HasData(Model.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", "FIRSTMODELTYPE"),
            //                //Model.Create(Guid.Parse("FIRSTMODELID2", "FIRSTMODELNAME2", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
            //                // Model.Create(Guid.Parse("FIRSTMODELID3", "FIRSTMODELNAME2", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                            Model.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "SECONDMODELNAME", "FIRSTMODELTYPE"),
                           Model.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "THIRDMODELNAME", "SECONDMODELTYPE"));
        }
    }

    public class TestFlowTypePathConfig : IEntityTypeConfiguration<TestFlowType>
    {
        public void Configure(EntityTypeBuilder<TestFlowType> entity)
        {
            entity.HasKey(e => new { e.TestingModeId });
            entity.Property(e => e.TestingMode).IsRequired();
            entity.HasData(TestFlowType.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), 1, "AUTOMATIC", "FLOW TYPES FOR LOADCELL"),
                TestFlowType.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), 2, "MANUAL", "FLOW TYPES FOR TESTLINKS"),
                TestFlowType.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), 3, "SCALES/PAD", "FLOW TYPES FOR SCALES/PAD"));



        }
    }
    public class DocumentBasePathConfig : IEntityTypeConfiguration<DocumentBasePath>
    {
        public void Configure(EntityTypeBuilder<DocumentBasePath> entity)
        {
            entity.HasKey(e => new { e.DocumentBasePathId });
            entity.Property(e => e.DocumentBasePathId).HasMaxLength(10);


        }
    }
    public class ModelVersionConfig : IEntityTypeConfiguration<ModelVersion>
    {
        public void Configure(EntityTypeBuilder<ModelVersion> entity)
        {
            entity.HasKey(e => new { e.ModelName, e.ModelVersionId });
            entity.Property(e => e.ModelName).HasMaxLength(FixedValues.ModelNameMaxLength);
            entity.Property(e => e.Capacity).IsRequired();
            entity.HasOne<ShellMaterial>(e => e.ShellMaterial).WithMany(e => e.ModelVersions).HasForeignKey(e => new { e.ShellMaterialName });
            entity.HasOne<Model>(e => e.Models).WithMany(ad => ad.ModelVersions)
                  .HasForeignKey(e => e.ModelName).HasPrincipalKey(e => e.ModelName);
            entity.HasData(ModelVersion.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRST_VERSION_FIRSTMODEL_NAME", 1, "SPECIAL DESIGN", "FIRSTMODELNAME", "AUTOMATIC", "OLADEJI", DateTime.UtcNow, 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
                , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true),
                  ModelVersion.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "SECOND_VERSION_FIRSTMODELNAME", 2, "AUTO DESIGN TO COMBAT SPLIILING", "FIRSTMODELNAME", "MANUAL", "OLADEJI", DateTime.UtcNow, 100, 2, 2, 2, 2, 2, 2, 2, 2, "SHELLMATERIAL1", true, 20, 2, 2, "CCNUMBER", "CLASS", "APPLICATION", 2, 2, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true),
                  ModelVersion.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "FIRST_VERSION_SECONDMODELNAME", 1, "INITIAL DESIGN", "SECONDMODELNAME", "GETVALUESFROMTESTINGFLOWTYPES", "OLADEJI", DateTime.UtcNow, 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1, 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true));


        }
    }


    public class DocumentConfig : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> entity)
        {
            entity.HasKey(e => new { e.DocumentName, e.ModelName, e.ModelVersionId });
            entity.Property(e => e.ModelName).HasMaxLength(FixedValues.ModelNameMaxLength);

            //entity.Property(e => e.ModelName).IsRequired().HasMaxLength(FixedValues.ModelNameMaxLength);//This has specified the foreign key
            entity.HasOne<ModelVersion>(e => e.ModelVersion).WithMany(e => e.Documents).HasForeignKey(e => new { e.ModelName, e.ModelVersionId });
            entity.HasData(Document.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME ver1 DOc", 1, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow),
                Document.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow),
                Document.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow),
                Document.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "FIRSTMODELNAME ver2 DOc A", 2, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow));
        }
    }




    public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> entity)
        {
            entity.HasKey(e => e.DocumentTypeName);
            entity.Property(e => e.DocumentTypeName).IsRequired().HasMaxLength(FixedValues.DocumentTypeMaxLength);
            entity.HasData(DocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "Cabling"),
                   DocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "Chroming"),
                    DocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "Sealing"),
                      DocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "Gauging"),
                   DocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "Wiring"));
        }
    }


    //public class SpecificationConfig : IEntityTypeConfiguration<Specification>
    //{
    //    public void Configure(EntityTypeBuilder<Specification> entity)
    //    {
    //        //entity.HasKey(e => new { e.Capacity, e.ModelName, e.ModelVersionId });
    //        entity.HasKey(e => new { e.ModelName, e.ModelVersionId });
    //        entity.Property(e => e.Capacity).IsRequired();


    //        entity.HasOne<ShellMaterial>(e => e.ShellMaterial).WithMany(e => e.CapacitySpecifications)
    //            .HasForeignKey(e => new { e.ShellMaterialName });
    //        entity.HasOne<ModelVersion>(e => e.ModelVersion).WithOne(e => e.Specification).HasForeignKey<Specification>(e => new { e.ModelName, e.ModelVersionId });
    //        // .HasForeignKey(e => new { e.ModelName, e.ModelVersionId });

    //        entity.HasData(
    //            Specification.Create(
    //            100,  1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
    //            , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow,true),

    //                  //      Specification.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "FIRSTMODELNAME", 1,
    //                  //101, DateTime.UtcNow, "OLADEJI", 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL2", 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
    //                  //, 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID2", DateTime.UtcNow),

    //                  //      Specification.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "FIRSTMODELNAME", 1,
    //                  //102, DateTime.UtcNow, "OLADEJI", 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL2", 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
    //                  //, 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID2", DateTime.UtcNow),

    //                  Specification.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "FIRSTMODELNAME", 2,
    //            100, DateTime.UtcNow, "OLADEJI", 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL2", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
    //            , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID2", DateTime.UtcNow),


    //            Specification.Create(Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"), "SECONDMODELNAME", 1,
    //            100, DateTime.UtcNow, "OLADEJI", 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL3", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
    //            , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID3", DateTime.UtcNow));
    //    }
    //}





    public class DocumentDocumentTypeConfig : IEntityTypeConfiguration<DocumentDocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentDocumentType> entity)
        {
            entity.HasKey(e => new { e.DocumentName, e.ModelName, e.ModelVersionId, e.DocumentTypeName });
            entity.Property(e => e.ModelName).HasMaxLength(FixedValues.ModelNameMaxLength);
            entity.HasOne<DocumentType>(e => e.DocumentType).WithMany(e => e.DocumentDocumentTypes).HasForeignKey(e => new { e.DocumentTypeName });
            entity.HasOne<Document>(e => e.Document).WithMany(e => e.DocumentDocumentTypes).HasForeignKey(e => new { e.DocumentName, e.ModelName, e.ModelVersionId });
            entity.HasData(
                       DocumentDocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "Cabling"),
                       DocumentDocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "Chroming"),
                       DocumentDocumentType.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "Sealing"),
                       DocumentDocumentType.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Cabling"),
                       DocumentDocumentType.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Chroming"),
                       DocumentDocumentType.Create(Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"), "FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Sealing")

                );



        }
    }
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(e => new { e.ProductId });
            entity.HasOne<ModelVersion>(e => e.ModelVersion).WithMany(ad => ad.Products).HasForeignKey(e => new { e.ModelName, e.ModelVersionId });
        }
    }
    public class TestPointConfig : IEntityTypeConfiguration<TestPoint>
    {
        public void Configure(EntityTypeBuilder<TestPoint> entity)
        {
            /// below comments to be removed not needed anymore
            /// Add thito the migration query after creating the migration EVERYTIME YOU CREATE A NEW MIGRATION
            /// BEFORE UPDATE
            /// 
            /*
             * 
            migrationBuilder.Sql("ALTER TABLE `CapacityTestPoint` DROP COLUMN `TestId`");
            migrationBuilder.Sql("ALTER TABLE `CapacityTestPoint` ADD `TestId` int AUTO_INCREMENT UNIQUE;");
            migrationBuilder.Sql("ALTER TABLE `CapacityTestPoint` ADD  PRIMARY KEY(ModelVersionId, ModelName, TestId);");
           
             */
            /// THIS IS THE WORK AROUND TO CREATE IDENTITY FIELD FOR TESTID, MAY BE FIXED IN THE FUTURE


            entity.HasKey(e => new { e.ModelName, e.ModelVersionId, e.Capacity, e.TestPointId });



            entity.HasOne<ModelVersion>(e => e.ModelVersion).WithMany(e => e.TestPoints)
                .HasForeignKey(e => new { e.ModelName, e.ModelVersionId, e.Capacity })
               .HasPrincipalKey(e => new { e.ModelName, e.ModelVersionId, e.Capacity });
            //  entity.HasIndex(e => new { e.ModelName, e.ModelVersionId, e.Capacity }).IsUnique();



            entity.HasData(TestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", 1, 100, 10000),
                 TestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", 1, 100, 2000),
                  TestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", 1, 100, 3000),
                   TestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", 1, 100, 4000),
                 // CapacityTestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "FIRSTMODELNAME", 1, 102, 39, 1),
                 TestPoint.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "SECONDMODELNAME", 1, 100, 49));


        }
    }
    public class ShellMaterialConfig : IEntityTypeConfiguration<ShellMaterial>
    {
        public void Configure(EntityTypeBuilder<ShellMaterial> entity)
        {
            entity.HasKey(e => new { e.ShellMaterialName });
            entity.HasData(ShellMaterial.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "ShellMaterial1", true),
                            ShellMaterial.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "ShellMaterial2", true),
                             ShellMaterial.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "ShellMaterial3", true),
                               ShellMaterial.Create(Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"), "ShellMaterial4", true));


        }
    }







}




