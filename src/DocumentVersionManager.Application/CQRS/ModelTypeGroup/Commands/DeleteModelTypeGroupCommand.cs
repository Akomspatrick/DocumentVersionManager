using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteModelTypeGroupCommand(ModelTypeGroupDeleteRequestDTO  DeleteModelTypeGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}