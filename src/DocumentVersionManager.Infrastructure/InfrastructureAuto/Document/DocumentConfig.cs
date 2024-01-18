using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class DocumentConfig : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> entity)
        {
            entity.HasKey(e => new { e.DocumentName,e.ModelVersionId,e.ModelName });
            entity.Property(e => e.DocumentName).HasMaxLength(32); 
            entity.Property(e => e.ModelName).HasMaxLength(32); 
            entity.Property(e => e.ContentPDFPath).HasMaxLength(160); 
            entity.Property(e => e.ChangeOrderPDFPath).HasMaxLength(160); 
            entity.Property(e => e.DocumentBasePathId).HasMaxLength(160); 
            entity.Property(e => e.DocumentDescription).HasMaxLength(160); 
            entity.HasOne<ModelVersion>(e => e.ModelVersion).WithMany(ad => ad.Documents).HasForeignKey(e => new {e.ModelVersionId,e.ModelName});
        }
    }
}