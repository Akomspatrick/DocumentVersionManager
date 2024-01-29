using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetModelVersionGroupQuery(ModelVersionGroupGetRequestDTO  RequestModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, ModelVersionGroupResponseDTO>>;
    public  record GetModelVersionGroupByGuidQuery(ModelVersionGroupGetRequestByGuidDTO  RequestModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, ModelVersionGroupResponseDTO>>;
    public  record GetModelVersionGroupByIdQuery(ModelVersionGroupGetRequestByIdDTO  RequestModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, ModelVersionGroupResponseDTO>>;
    public  record GetAllModelVersionGroupQuery :  IRequest<Either<GeneralFailure, IEnumerable<ModelVersionGroupResponseDTO>>>;
}