using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateShellMaterialCommand(ShellMaterialCreateRequestDTO  CreateShellMaterialDTO) :  IRequest<Result<GeneralFailure, Guid>>;
}