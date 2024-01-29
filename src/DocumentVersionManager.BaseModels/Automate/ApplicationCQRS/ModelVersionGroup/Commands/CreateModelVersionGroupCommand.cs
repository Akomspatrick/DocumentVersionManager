using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateModelVersionGroupCommand(ModelVersionGroupCreateRequestDTO  CreateModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}