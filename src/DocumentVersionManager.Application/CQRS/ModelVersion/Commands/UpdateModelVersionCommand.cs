using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record UpdateModelVersionCommand(ModelVersionUpdateRequestDTO  UpdateModelVersionDTO) :  IRequest<Either<GeneralFailure, int>>;
}