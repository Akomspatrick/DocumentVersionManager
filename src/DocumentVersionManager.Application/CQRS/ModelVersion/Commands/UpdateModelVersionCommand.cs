using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record UpdateModelVersionCommand(ModelVersionUpdateRequestDTO  UpdateModelVersionDTO) :  IRequest<Result<GeneralFailure, int>>;
}