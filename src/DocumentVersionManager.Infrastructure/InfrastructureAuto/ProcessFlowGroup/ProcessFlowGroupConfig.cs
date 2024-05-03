using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.EntitiesConfig
{
    public class ProcessFlowGroupConfig : IEntityTypeConfiguration<ProcessFlowGroup>
    {
        public void Configure(EntityTypeBuilder<ProcessFlowGroup> entity)
        {
            entity.HasKey(e => new { e.ProcessFlowGroupName });
            entity.Property(e => e.ProcessFlowGroupName).HasMaxLength(32); 
            entity.Property(e => e.DefaultTestingMode).HasMaxLength(32); 
            entity.Property(e => e.Description).HasMaxLength(64); 
            entity.Property(e => e.ProcessFlowGroupName).IsRequired(); 
        }
    }
}