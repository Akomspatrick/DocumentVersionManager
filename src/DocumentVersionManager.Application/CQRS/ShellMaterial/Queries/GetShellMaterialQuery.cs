using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetShellMaterialQuery(ShellMaterialGetRequestDTO  RequestShellMaterialDTO) :  IRequest<Result<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetShellMaterialByGuidQuery(ShellMaterialGetRequestByGuidDTO  RequestShellMaterialDTO) :  IRequest<Result<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetShellMaterialByIdQuery(ShellMaterialGetRequestByIdDTO  RequestShellMaterialDTO) :  IRequest<Result<GeneralFailure, ShellMaterialResponseDTO>>;
    public  record GetAllShellMaterialQuery :  IRequest<Result<GeneralFailure, IEnumerable<ShellMaterialResponseDTO>>>;
}