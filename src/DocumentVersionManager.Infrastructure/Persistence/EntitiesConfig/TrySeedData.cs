
using DocumentVersionManager.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentVersionManager.Infrastructure.Persistence
{
    public static class TrySeedData
    {


        public async static Task EnsureUsers(this WebApplication app)
        {

            using var scope = app.Services.CreateScope();
            //Migration Should have been Created Might not have been Ran/Runned
            {
                try
                {
                    await scope.ServiceProvider.GetRequiredService<DocumentVersionManagerContext>().Database.MigrateAsync();
                    var ctx = scope.ServiceProvider.GetRequiredService<DocumentVersionManagerContext>();
                    // if (await ctx.Database.EnsureCreatedAsync())
                    {

                        var testData = ctx.ModelTypeGroups.Any();
                        if (!testData)
                        {
                            var data = new List<ModelTypeGroup>
                            {
                                ModelTypeGroup.Create("LOADCELLS_GROUP", "AUTOMATIC", "FLOW TYPES FOR LOADCELL", Guid.NewGuid()),
                                ModelTypeGroup.Create("TESTLINKS_GROUP", "MANUAL", "FLOW TYPES FOR TESTLINKS", Guid.NewGuid()),
                                ModelTypeGroup.Create("SCALES/PAD", "MANUAL", "FLOW TYPES FOR SCALES/PAD",Guid.NewGuid())
                            };
                            ctx.ModelTypeGroups.AddRange(data);
                            ctx.SaveChanges();


                        }

                        var modelTypes = ctx.ModelTypes.Any();
                        if (!modelTypes)
                        {
                            var data = new List<ModelType>
                            {
                                ModelType.Create("FIRSTMODELTYPE", "LOADCELLS_GROUP", Guid.NewGuid()),
                                ModelType.Create("SECONDMODELTYPE", "TESTLINKS_GROUP", Guid.NewGuid()),
                                ModelType.Create("THIRDMODELTYPE", "SCALES/PAD", Guid.NewGuid())
                            };
                            ctx.ModelTypes.AddRange(data);
                            ctx.SaveChanges();
                        }

                        var models = ctx.Models.Any();
                        if (!models)
                        {
                            var data = new List<Model>
                            {
                                Model.Create("FIRSTMODELNAME", "FIRSTMODELTYPE", Guid.NewGuid()),
                                Model.Create("SECONDMODELNAME", "FIRSTMODELTYPE", Guid.NewGuid()),
                                Model.Create("THIRDMODELNAME", "SECONDMODELTYPE", Guid.NewGuid())
                            };
                            ctx.Models.AddRange(data);
                            ctx.SaveChanges();
                        }
                        //entity.HasData(Model.Create("FIRSTMODELNAME", "FIRSTMODELTYPE", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //                Model.Create("SECONDMODELNAME", "FIRSTMODELTYPE", Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5")),
                        //               Model.Create("THIRDMODELNAME", "SECONDMODELTYPE", Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b")));

                        var shellMaterials = ctx.ShellMaterials.Any();
                        if (!shellMaterials)
                        {
                            var data = new List<ShellMaterial>
                            {
                                ShellMaterial.Create("ShellMaterial1", true, Guid.NewGuid()),
                                ShellMaterial.Create("ShellMaterial2", true, Guid.NewGuid()),
                                ShellMaterial.Create("ShellMaterial3", true, Guid.NewGuid()),
                                ShellMaterial.Create("ShellMaterial4", true, Guid.NewGuid())
                            };
                            ctx.ShellMaterials.AddRange(data);
                            ctx.SaveChanges();
                        }
                        var modelVersions = ctx.ModelVersions.Any();
                        if (!modelVersions)
                        {
                            var data = new List<ModelVersion>
                               {
                                ModelVersion.Create(1, "SPECIAL DESIGN", "FIRST_VERSION_FIRSTMODEL_NAME", "FIRSTMODELNAME", "AUTOMATIC", DateTime.UtcNow, "OLADEJI", 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
                                                               , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.NewGuid()),
                                ModelVersion.Create(2, "AUTO DESIGN TO COMBAT SPLIILING", "SECOND_VERSION_FIRSTMODELNAME", "FIRSTMODELNAME", "MANUAL", DateTime.UtcNow, "OLADEJI", 100, 2, 2, 2, 2, 2, 2, 2, 2, "SHELLMATERIAL1", true, 20, 2, 2, "CCNUMBER", "CLASS", "APPLICATION", 2, 2, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.NewGuid()),
                                ModelVersion.Create(1, "INITIAL DESIGN", "FIRST_VERSION_SECONDMODELNAME", "SECONDMODELNAME", "GETVALUESFROMTESTINGFLOWTYPES", DateTime.UtcNow, "OLADEJI", 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1, 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.NewGuid())
                        
                                
                                
                                
                                
                                
                              
                                
                                
                                
                                
                                //   public static ModelVersion Create(int  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  defaultTestingMode, DateTime  timestamp, string  userName, int  capacity, Double  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, int  minimumDeadLoad, Double  vMin, int  nMax, int  safeLoad, int  ultimateLoad, string  shellMaterialName, Boolean  alloy, int  defaultCableLength, int  numberOfGauges, int  resistance, string  cCNumber, string  accuracyClass, string  application, int  temperingHardnessLow, int  temperingHardnessHigh, string  nTEPCertificationId, DateTime  nTEPCertificationTimestamp, string  oIMLCertificationId, DateTime  oIMLCertificationTimestamp, Boolean  testPointDirection, Guid  guidId)

                            };
                            ctx.ModelVersions.AddRange(data);
                            ctx.SaveChanges();
                        }

                        //entity.HasData(ModelVersion.Create(1, "SPECIAL DESIGN", "FIRST_VERSION_FIRSTMODEL_NAME", "FIRSTMODELNAME", "AUTOMATIC", DateTime.UtcNow, "OLADEJI", 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1
                        //    , 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //      ModelVersion.Create(2, "AUTO DESIGN TO COMBAT SPLIILING", "SECOND_VERSION_FIRSTMODELNAME", "FIRSTMODELNAME", "MANUAL", DateTime.UtcNow, "OLADEJI", 100, 2, 2, 2, 2, 2, 2, 2, 2, "SHELLMATERIAL1", true, 20, 2, 2, "CCNUMBER", "CLASS", "APPLICATION", 2, 2, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5")),
                        //      ModelVersion.Create(1, "INITIAL DESIGN", "FIRST_VERSION_SECONDMODELNAME", "SECONDMODELNAME", "GETVALUESFROMTESTINGFLOWTYPES", DateTime.UtcNow, "OLADEJI", 100, 1, 1, 1, 1, 1, 1, 1, 1, "SHELLMATERIAL1", true, 20, 1, 1, "CCNUMBER", "CLASS", "APPLICATION", 1, 1, "NTEPCERTIFICATIONID", DateTime.UtcNow, "OIMLCERTIFICATIONID1", DateTime.UtcNow, true, Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b")));


                        var modelversiondocuments = ctx.ModelVersionDocuments.Any();

                        if (!modelversiondocuments)
                        {
                            var data = new List<ModelVersionDocument>
                            {
                                ModelVersionDocument.Create(1, "FIRSTMODELNAME",1, "DOC DESCRPTION", "CABLING", "c:\\","DOCPATH", "DOCNAME1.pdf", DateTime.UtcNow, "USER1",Guid.NewGuid()),
                                ModelVersionDocument.Create(2, "FIRSTMODELNAME",1, "DOC DESCRPTION", "WIRING", "c:\\","DOCPATH", "DOCNAME1.pdf", DateTime.UtcNow,"USER1", Guid.NewGuid()),
                                ModelVersionDocument.Create(1, "SECONDMODELNAME",1, "DOC DESCRPTION", "WIRING", "c:\\","DOCPATH", "DOCNAME1.pdf", DateTime.UtcNow,"USER1",   Guid.NewGuid()),
                                ModelVersionDocument.Create(1, "SECONDMODELNAME",2, "DOC DESCRPTION", "WIRING", "c:\\","DOCPATH", "DOCNAME2.pdf", DateTime.UtcNow, "USER1", Guid.NewGuid()),
                                ModelVersionDocument.Create(1, "SECONDMODELNAME", 3,"DOC DESCRPTION", "WIRING", "c:\\","DOCPATH", "DOCNAME3.pdf", DateTime.UtcNow, "USER1", Guid.NewGuid())
                            };
                            ctx.ModelVersionDocuments.AddRange(data);
                            ctx.SaveChanges();
                        }
                        //var documents = ctx.Documents.Any();
                        //if (!documents)
                        //{
                        //    var data = new List<Document>
                        //    {
                        //        Document.Create("FIRSTMODELNAME ver1 DOc",1, "FIRSTMODELNAME",  "CONTENT PDF PATH", "CHANGE ORDER PATH", "DOCPATHID", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow, Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        Document.Create("FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "DOCPATHID", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow, Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        Document.Create("FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "DOCPATHID", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow, Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5")),
                        //        Document.Create("FIRSTMODELNAME ver2 DOc A", 2,"FIRSTMODELNAME", "CONTENT PDF PATH", "CHANGE ORDER PATH", "DOCPATHID", "SIMPLE DESCRITION OF DOCUMENT", DateTime.UtcNow, Guid.Parse("58dcf5c5-5a00-4ffa-bb37-9374a8d3c69b"))
                        //    };
                        //    ctx.Documents.AddRange(data);
                        //    ctx.SaveChanges();
                        //}

                        //var documentTypes = ctx.DocumentTypes.Any();
                        //if (!documentTypes)
                        //{
                        //    var data = new List<DocumentType>
                        //    {
                        //        DocumentType.Create("Cabling", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentType.Create("Chroming", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentType.Create("Sealing", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentType.Create("Gauging", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentType.Create("Wiring", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63"))
                        //    };
                        //    ctx.DocumentTypes.AddRange(data);
                        //    ctx.SaveChanges();
                        //}

                        //var documentDocumentTypes = ctx.DocumentDocumentTypes.Any();
                        //if (!documentDocumentTypes)
                        //{
                        //    var data = new List<DocumentDocumentType>
                        //    {
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc A",1, "FIRSTMODELNAME",  "Cabling", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "Chroming", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc A", 1, "FIRSTMODELNAME", "Sealing", Guid.Parse("b27c2c19-522b-49d1-83bf-e80d4dde8c63")),
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Cabling", Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5")),
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Chroming", Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5")),
                        //        DocumentDocumentType.Create("FIRSTMODELNAME ver1 DOc B", 1, "FIRSTMODELNAME", "Sealing", Guid.Parse("7808711f-544a-423d-8d99-f00c31e35be5"))
                        //    };
                        //    ctx.DocumentDocumentTypes.AddRange(data);
                        //    ctx.SaveChanges();
                        //}

                        var testPoints = ctx.TestPoints.Any();
                        if (!testPoints)
                        {
                            var data = new List<TestPoint>
                            {
                                TestPoint.Create( 1, "FIRSTMODELNAME",10000, Guid.NewGuid()),
                                TestPoint.Create(1,"FIRSTMODELNAME",  2000, Guid.NewGuid()),
                                TestPoint.Create(1, "FIRSTMODELNAME", 3000, Guid.NewGuid()),
                                TestPoint.Create(1, "FIRSTMODELNAME", 4000, Guid.NewGuid()),
                                TestPoint.Create(1, "SECONDMODELNAME", 49, Guid.NewGuid())
                            };
                            ctx.TestPoints.AddRange(data);
                            ctx.SaveChanges();
                        }




                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }



        }


    }
}
