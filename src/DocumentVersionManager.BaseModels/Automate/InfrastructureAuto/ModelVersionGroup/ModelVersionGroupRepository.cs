using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Domain.Entities;
namespace DocumentVersionManager.Infrastructure.Persistence.Repositories

{
    public  class  ModelVersionGroupRepository:GenericRepository<ModelVersionGroup>, IModelVersionGroupRepository
    {
        public   ModelVersionGroupRepository( DocumentVersionManagerContext ctx): base(ctx)
        {}
    }
}