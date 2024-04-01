using DocumentVersionManager.Contracts.RequestDTO.V1.auto;
using DocumentVersionManager.Contracts.ResponseDTO.V1.auto;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record GetShellMaterialQuery(ShellMaterialGetRequestDTO  RequestShellMaterialDTO) :  IRequest<Either<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetShellMaterialByGuidQuery(ShellMaterialGetRequestByGuidDTO  RequestShellMaterialDTO) :  IRequest<Either<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetShellMaterialByIdQuery(ShellMaterialGetRequestByIdDTO  RequestShellMaterialDTO) :  IRequest<Either<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetAllShellMaterialQuery :  IRequest<Either<GeneralFailure, IEnumerable<ShellMaterialResponseDTO>>>;
}