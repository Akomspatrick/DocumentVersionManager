using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS.Product.Queries{
    public  record GetProductQuery(ApplicationProductGetRequestDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ApplicationProductResponseDTO>>;
    public  record GetProductByGuidQuery(ApplicationProductGetRequestByGuidDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ApplicationProductResponseDTO>>;
    public  record GetProductByIdQuery(ApplicationProductGetRequestByIdDTO  RequestProductDTO) :  IRequest<Either<GeneralFailure, ApplicationProductResponseDTO>>;
    public  record GetAllProductQuery :  IRequest<Either<GeneralFailure, IEnumerable<ApplicationProductResponseDTO>>>;
}