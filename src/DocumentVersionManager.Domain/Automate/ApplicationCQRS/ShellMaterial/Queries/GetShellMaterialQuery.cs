using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ShellMaterial.Queries
{
    public  record GetShellMaterialQuery(ApplicationShellMaterialGetRequestDTO  RequestShellMaterialDTO) :  IRequest<Either<GeneralFailure, ApplicationShellMaterialResponseDTO>>;
}