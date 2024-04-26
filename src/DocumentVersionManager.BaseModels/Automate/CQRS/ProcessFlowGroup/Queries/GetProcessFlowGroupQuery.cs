using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetProcessFlowGroupQuery(ProcessFlowGroupGetRequestDTO  RequestProcessFlowGroupDTO) :  IRequest<Either<GeneralFailure, ProcessFlowGroupResponseDTO>>;
    public  record GetProcessFlowGroupByGuidQuery(ProcessFlowGroupGetRequestByGuidDTO  RequestProcessFlowGroupDTO) :  IRequest<Either<GeneralFailure, ProcessFlowGroupResponseDTO>>;
    public  record GetProcessFlowGroupByIdQuery(ProcessFlowGroupGetRequestByIdDTO  RequestProcessFlowGroupDTO) :  IRequest<Either<GeneralFailure, ProcessFlowGroupResponseDTO>>;
    public  record GetAllProcessFlowGroupQuery :  IRequest<Either<GeneralFailure, IEnumerable<ProcessFlowGroupResponseDTO>>>;
}