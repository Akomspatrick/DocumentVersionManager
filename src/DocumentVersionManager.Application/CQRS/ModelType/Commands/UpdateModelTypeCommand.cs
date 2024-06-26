using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ModelType.Commands
{
    public  record UpdateModelTypeCommand(ModelTypeUpdateRequestDTO  UpdateModelTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}