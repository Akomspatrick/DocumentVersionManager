using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteModelVersionGroupCommand(ModelVersionGroupDeleteRequestDTO  DeleteModelVersionGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}