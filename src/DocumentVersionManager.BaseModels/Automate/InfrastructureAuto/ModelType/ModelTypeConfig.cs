using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ModelTypeConfig : IEntityTypeConfiguration<ModelType>
    {
        public void Configure(EntityTypeBuilder<ModelType> entity)
        {
            entity.HasKey(e => new { e.ModelTypeName });
            entity.Property(e => e.ModelTypeName).HasMaxLength(32); 
            entity.Property(e => e.ProcessFlowGroupName).HasMaxLength(32); 
            entity.HasOne<ProcessFlowGroup>(e => e.ProcessFlowGroup).WithMany(ad => ad.ModelTypes).HasForeignKey(e => new {e.ProcessFlowGroupName});
            
        }
    }
}