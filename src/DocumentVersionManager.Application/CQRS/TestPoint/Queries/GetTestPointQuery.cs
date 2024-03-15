using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetTestPointQuery(TestPointGetRequestDTO  RequestTestPointDTO) :  IRequest<Result<GeneralFailure, TestPointResponseDTO>>;
    public  record GetTestPointByGuidQuery(TestPointGetRequestByGuidDTO  RequestTestPointDTO) :  IRequest<Result<GeneralFailure, TestPointResponseDTO>>;
    public  record GetTestPointByIdQuery(TestPointGetRequestByIdDTO  RequestTestPointDTO) :  IRequest<Result<GeneralFailure, TestPointResponseDTO>>;
    public  record GetAllTestPointQuery :  IRequest<Result<GeneralFailure, IEnumerable<TestPointResponseDTO>>>;
}