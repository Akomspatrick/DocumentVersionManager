using LanguageExt;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken);
        // I can logics that are centrall to this place
        //IModelRepository ModelRepository { get; }
        //IModelTypeRepository ModelTypeRepository { get; }
        //IModelVersionRepository ModelVersionRepository { get; }
        //IModelVersionDocumentRepository ModelVersionDocumentRepository { get; }
        //IShellMaterialRepository ShellMaterialRepository { get; }
        //ITestingModeGroupRepository TestingModeGroupRepository { get; }
        //ITestPointRepository TestPointRepository { get; }
    }
}