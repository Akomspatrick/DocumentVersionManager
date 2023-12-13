using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.ModelVersion.Commands
{
    public  record UpdateModelVersionCommand(ApplicationModelVersionUpdateRequestDTO  UpdateModelVersionDTO) :  IRequest<Either<GeneralFailure, int>>;
}