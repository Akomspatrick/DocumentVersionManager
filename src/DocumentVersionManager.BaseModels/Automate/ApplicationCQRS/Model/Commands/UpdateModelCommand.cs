using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record UpdateModelCommand(ModelUpdateRequestDTO  UpdateModelDTO) :  IRequest<Result<GeneralFailure, int>>;
}