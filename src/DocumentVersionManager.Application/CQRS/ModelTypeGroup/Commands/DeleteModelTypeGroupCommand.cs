using DocumentVersionManager.Contracts.RequestDTO.V1.auto;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteTestingModeGroupCommand(TestingModeGroupDeleteRequestDTO  DeleteTestingModeGroupDTO) :  IRequest<Either<GeneralFailure, int>>;
}