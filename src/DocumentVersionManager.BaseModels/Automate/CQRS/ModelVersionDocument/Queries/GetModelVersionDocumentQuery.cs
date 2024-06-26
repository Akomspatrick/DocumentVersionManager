using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelVersionDocumentQuery(ModelVersionDocumentGetRequestDTO  RequestModelVersionDocumentDTO) :  IRequest<Either<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetModelVersionDocumentByGuidQuery(ModelVersionDocumentGetRequestByGuidDTO  RequestModelVersionDocumentDTO) :  IRequest<Either<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetModelVersionDocumentByIdQuery(ModelVersionDocumentGetRequestByIdDTO  RequestModelVersionDocumentDTO) :  IRequest<Either<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetAllModelVersionDocumentQuery :  IRequest<Either<GeneralFailure, IEnumerable<ModelVersionDocumentResponseDTO>>>;
}