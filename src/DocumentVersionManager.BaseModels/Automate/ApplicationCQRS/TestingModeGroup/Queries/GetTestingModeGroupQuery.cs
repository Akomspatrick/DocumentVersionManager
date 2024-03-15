using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetTestingModeGroupQuery(TestingModeGroupGetRequestDTO  RequestTestingModeGroupDTO) :  IRequest<Result<GeneralFailure, TestingModeGroupResponseDTO>>;
    public  record GetTestingModeGroupByGuidQuery(TestingModeGroupGetRequestByGuidDTO  RequestTestingModeGroupDTO) :  IRequest<Result<GeneralFailure, TestingModeGroupResponseDTO>>;
    public  record GetTestingModeGroupByIdQuery(TestingModeGroupGetRequestByIdDTO  RequestTestingModeGroupDTO) :  IRequest<Result<GeneralFailure, TestingModeGroupResponseDTO>>;
    public  record GetAllTestingModeGroupQuery :  IRequest<Result<GeneralFailure, IEnumerable<TestingModeGroupResponseDTO>>>;
}