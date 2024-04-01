using DocumentVersionManager.Contracts.RequestDTO.V1.auto;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record UpdateTestingModeGroupCommand(TestingModeGroupUpdateRequestDTO  UpdateTestingModeGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}