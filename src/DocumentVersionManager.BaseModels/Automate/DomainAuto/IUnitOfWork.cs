using LanguageExt;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken);
        IModelRepository ModelRepository { get; }
        IModelTypeRepository ModelTypeRepository { get; }
        IModelTypeGroupRepository ModelTypeGroupRepository { get; }
        IModelVersionRepository ModelVersionRepository { get; }
        IModelVersionDocumentRepository ModelVersionDocumentRepository { get; }
        IProductRepository ProductRepository { get; }
        IShellMaterialRepository ShellMaterialRepository { get; }
        ITestPointRepository TestPointRepository { get; }
    }
}