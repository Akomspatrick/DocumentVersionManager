//using DocumentVersionManager.DomainBase.Result;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
namespace DocumentVersionManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<Result<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken);
        IModelRepository ModelRepository { get; }
        IModelTypeRepository ModelTypeRepository { get; }
        IModelVersionRepository ModelVersionRepository { get; }
        IModelVersionDocumentRepository ModelVersionDocumentRepository { get; }
        IShellMaterialRepository ShellMaterialRepository { get; }
        ITestingModeGroupRepository TestingModeGroupRepository { get; }
        ITestPointRepository TestPointRepository { get; }
    }
}