using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.DocumentBasePath.Queries
{
    public  record GetAllDocumentBasePathQuery(ApplicationRequestDocumentBasePathDTO  RequestDocumentBasePathDTO) :  IRequest<Either<GeneralFailure, IEnumerable<ApplicationResponseDocumentBasePathDTO>>>;
}