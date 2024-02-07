using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class TestingModeGroupConfig : IEntityTypeConfiguration<TestingModeGroup>
    {
        public void Configure(EntityTypeBuilder<TestingModeGroup> entity)
        {
            entity.HasKey(e => new { e.ModelVersionGroupName });
            entity.Property(e => e.ModelVersionGroupName).HasMaxLength(32); 
            entity.Property(e => e.DefaultTestingMode).HasMaxLength(32); 
            entity.Property(e => e.Description).HasMaxLength(64); 
            entity.Property(e => e.ModelVersionGroupName).IsRequired(); 
        }
    }
}