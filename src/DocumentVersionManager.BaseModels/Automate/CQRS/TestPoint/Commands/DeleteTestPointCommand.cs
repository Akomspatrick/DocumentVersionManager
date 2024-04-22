using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteTestPointCommand(TestPointDeleteRequestDTO  DeleteTestPointDTO) :  IRequest<Either<GeneralFailure, int>>;
}