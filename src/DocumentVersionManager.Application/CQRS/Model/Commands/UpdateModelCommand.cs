
using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.Model.Commands
{
    public  record UpdateModelCommand(ModelUpdateRequestDTO  UpdateModelDTO) :  IRequest<Result<GeneralFailure, int>>;
}