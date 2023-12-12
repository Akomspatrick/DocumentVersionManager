using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.Specification.Queries
{
    public  record GetSpecificationQuery(ApplicationRequestSpecificationDTO  RequestSpecificationDTO) :  IRequest<Either<GeneralFailure, ApplicationResponseSpecificationDTO>>;
}