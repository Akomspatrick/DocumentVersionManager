using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelQuery(ModelGetRequestDTO  RequestModelDTO) :  IRequest<Result<GeneralFailure, ModelResponseDTO>>;
    public  record GetModelByGuidQuery(ModelGetRequestByGuidDTO  RequestModelDTO) :  IRequest<Result<GeneralFailure, ModelResponseDTO>>;
    public  record GetModelByIdQuery(ModelGetRequestByIdDTO  RequestModelDTO) :  IRequest<Result<GeneralFailure, ModelResponseDTO>>;
    public  record GetAllModelQuery :  IRequest<Result<GeneralFailure, IEnumerable<ModelResponseDTO>>>;
}