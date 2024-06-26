using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.Model.Commands
{
    public  record UpdateModelCommand(ModelUpdateRequestDTO  UpdateModelDTO) :  IRequest<Either<GeneralFailure, int>>;
}