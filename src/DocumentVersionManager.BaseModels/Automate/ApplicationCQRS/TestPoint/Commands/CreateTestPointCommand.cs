using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateTestPointCommand(TestPointCreateRequestDTO  CreateTestPointDTO) :  IRequest<Result<GeneralFailure, Guid>>;
}