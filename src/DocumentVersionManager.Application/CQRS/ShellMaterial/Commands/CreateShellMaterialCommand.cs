using DocumentVersionManager.Contracts.RequestDTO.V1.auto;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateShellMaterialCommand(ShellMaterialCreateRequestDTO  CreateShellMaterialDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}