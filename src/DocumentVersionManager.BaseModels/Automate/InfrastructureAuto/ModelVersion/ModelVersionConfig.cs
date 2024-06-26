using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ModelVersionConfig : IEntityTypeConfiguration<ModelVersion>
    {
        public void Configure(EntityTypeBuilder<ModelVersion> entity)
        {
            entity.HasKey(e => new { e.ModelVersionId,e.ModelName });
            entity.Property(e => e.VersionDescription).HasMaxLength(160); 
            entity.Property(e => e.ModelVersionName).HasMaxLength(32); 
            entity.Property(e => e.ModelName).HasMaxLength(32); 
            entity.Property(e => e.DefaultTestingMode).HasMaxLength(32); 
            entity.Property(e => e.UserName).HasMaxLength(32); 
            entity.Property(e => e.NominalOutput).HasPrecision(18,6); 
            entity.Property(e => e.NominalOutputPercentage).HasPrecision(18,6); 
            entity.Property(e => e.NonlinearityPercentage).HasPrecision(18,6); 
            entity.Property(e => e.vMin).HasPrecision(11,1); 
            entity.Property(e => e.ShellMaterialName).HasMaxLength(32); 
            entity.Property(e => e.Capacity).IsRequired(); 
            entity.HasOne<Model>(e => e.Model).WithMany(ad => ad.ModelVersions).HasForeignKey(e => new {e.ModelName});
        }
    }
}