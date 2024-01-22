using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  record DeleteProductCommand(ProductDeleteRequestDTO  DeleteProductDTO) :  IRequest<Either<GeneralFailure, int>>;
}