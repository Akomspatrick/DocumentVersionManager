using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteTestingModeGroupCommand(TestingModeGroupDeleteRequestDTO  DeleteTestingModeGroupDTO) :  IRequest<Result<GeneralFailure, int>>;
}