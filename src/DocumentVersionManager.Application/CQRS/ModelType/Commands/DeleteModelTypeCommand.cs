using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ModelType.Commands
{
    public  record DeleteModelTypeCommand(ModelTypeDeleteRequestDTO  DeleteModelTypeDTO) :  IRequest<Result<GeneralFailure, int>>;
}