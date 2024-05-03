using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.Repositories

{
    public  class  ProcessFlowGroupRepository:GenericRepository<ProcessFlowGroup>, IProcessFlowGroupRepository
    {
        public   ProcessFlowGroupRepository( DocumentVersionManagerContext ctx): base(ctx)
        {}
    }
}