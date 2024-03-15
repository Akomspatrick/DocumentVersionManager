using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateModelCommand(ModelCreateRequestDTO  CreateModelDTO) :  IRequest<Result<GeneralFailure, Guid>>;
}