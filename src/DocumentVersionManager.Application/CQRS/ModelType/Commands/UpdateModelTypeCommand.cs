
using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ModelType.Commands
{
    public  record UpdateModelTypeCommand(ModelTypeUpdateRequestDTO  UpdateModelTypeDTO) :  IRequest<Result<GeneralFailure, int>>;
}