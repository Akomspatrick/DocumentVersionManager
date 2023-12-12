using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.TestFlowType.Commands
{
    public  record CreateTestFlowTypeCommand(ApplicationCreateTestFlowTypeDTO  CreateTestFlowTypeDTO) :  IRequest<Either<GeneralFailure, int>>;
}