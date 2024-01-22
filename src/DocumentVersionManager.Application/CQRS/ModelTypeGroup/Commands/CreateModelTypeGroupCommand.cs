using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateModelTypeGroupCommand(ModelTypeGroupCreateRequestDTO  CreateModelTypeGroupDTO) :  IRequest<Either<GeneralFailure, Guid>>;
}