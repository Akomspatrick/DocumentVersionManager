using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record CreateTestingModeGroupCommand(TestingModeGroupCreateRequestDTO  CreateTestingModeGroupDTO) :  IRequest<Result<GeneralFailure, Guid>>;
}