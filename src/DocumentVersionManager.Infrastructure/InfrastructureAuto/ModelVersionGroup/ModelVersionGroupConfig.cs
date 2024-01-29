using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ModelVersionGroupConfig : IEntityTypeConfiguration<ModelVersionGroup>
    {
        public void Configure(EntityTypeBuilder<ModelVersionGroup> entity)
        {
            entity.HasKey(e => new { e.ModelVersionGroupName });
            entity.Property(e => e.ModelVersionGroupName).HasMaxLength(32); 
            entity.Property(e => e.DefaultTestingMode).HasMaxLength(32); 
            entity.Property(e => e.Description).HasMaxLength(64); 
            entity.Property(e => e.ModelVersionGroupName).IsRequired(); 
        }
    }
}