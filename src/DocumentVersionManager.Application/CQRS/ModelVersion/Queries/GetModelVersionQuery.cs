using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelVersionQuery(ModelVersionGetRequestDTO  RequestModelVersionDTO) :  IRequest<Result<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetModelVersionByGuidQuery(ModelVersionGetRequestByGuidDTO  RequestModelVersionDTO) :  IRequest<Result<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetModelVersionByIdQuery(ModelVersionGetRequestByIdDTO  RequestModelVersionDTO) :  IRequest<Result<GeneralFailure, ModelVersionResponseDTO>>;
    public  record GetAllModelVersionQuery :  IRequest<Result<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>>;
}