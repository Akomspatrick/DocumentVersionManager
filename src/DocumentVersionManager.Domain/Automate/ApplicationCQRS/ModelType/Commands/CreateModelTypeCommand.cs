using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ModelType.Commands
{
    public  record CreateModelTypeCommand(ApplicationCreateModelTypeDTO  CreateModelTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}