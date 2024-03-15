using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelVersionDocumentQuery(ModelVersionDocumentGetRequestDTO  RequestModelVersionDocumentDTO) :  IRequest<Result<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetModelVersionDocumentByGuidQuery(ModelVersionDocumentGetRequestByGuidDTO  RequestModelVersionDocumentDTO) :  IRequest<Result<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetModelVersionDocumentByIdQuery(ModelVersionDocumentGetRequestByIdDTO  RequestModelVersionDocumentDTO) :  IRequest<Result<GeneralFailure, ModelVersionDocumentResponseDTO>>;
    public  record GetAllModelVersionDocumentQuery :  IRequest<Result<GeneralFailure, IEnumerable<ModelVersionDocumentResponseDTO>>>;
}