using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetTestPointQuery(TestPointGetRequestDTO  RequestTestPointDTO) :  IRequest<Either<GeneralFailure, TestPointResponseDTO>>;
    public  record GetTestPointByGuidQuery(TestPointGetRequestByGuidDTO  RequestTestPointDTO) :  IRequest<Either<GeneralFailure, TestPointResponseDTO>>;
    public  record GetTestPointByIdQuery(TestPointGetRequestByIdDTO  RequestTestPointDTO) :  IRequest<Either<GeneralFailure, TestPointResponseDTO>>;
    public  record GetAllTestPointQuery :  IRequest<Either<GeneralFailure, IEnumerable<TestPointResponseDTO>>>;
}