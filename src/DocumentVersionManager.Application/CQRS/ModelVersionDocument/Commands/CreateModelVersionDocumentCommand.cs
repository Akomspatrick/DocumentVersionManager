using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateModelVersionDocumentCommand(ModelVersionDocumentCreateRequestDTO  CreateModelVersionDocumentDTO) :  IRequest<Result<GeneralFailure, Guid>>;
}