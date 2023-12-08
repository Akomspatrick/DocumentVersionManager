using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.Document.Commands
{
    public  record UpdateDocumentCommand(ApplicationUpdateDocumentDTO  UpdateDocumentDTO) :  IRequest<Either<GeneralFailure, int>>;
}