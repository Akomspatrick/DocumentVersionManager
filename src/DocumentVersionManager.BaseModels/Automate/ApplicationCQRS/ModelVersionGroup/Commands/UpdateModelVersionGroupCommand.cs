using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record UpdateModelVersionGroupCommand(ModelVersionGroupUpdateRequestDTO  UpdateModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}