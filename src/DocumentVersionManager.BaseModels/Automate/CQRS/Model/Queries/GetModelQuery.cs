using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelQuery(ModelGetRequestDTO  RequestModelDTO) :  IRequest<Either<GeneralFailure, ModelResponseDTO>>;
    public  record GetModelByGuidQuery(ModelGetRequestByGuidDTO  RequestModelDTO) :  IRequest<Either<GeneralFailure, ModelResponseDTO>>;
    public  record GetModelByIdQuery(ModelGetRequestByIdDTO  RequestModelDTO) :  IRequest<Either<GeneralFailure, ModelResponseDTO>>;
    public  record GetAllModelQuery :  IRequest<Either<GeneralFailure, IEnumerable<ModelResponseDTO>>>;
}