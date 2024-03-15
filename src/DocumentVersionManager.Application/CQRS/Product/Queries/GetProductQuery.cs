using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS{
    public  record GetProductQuery(ProductGetRequestDTO  RequestProductDTO) :  IRequest<Result<GeneralFailure, ProductResponseDTO>>;
    public  record GetProductByGuidQuery(ProductGetRequestByGuidDTO  RequestProductDTO) :  IRequest<Result<GeneralFailure, ProductResponseDTO>>;
    public  record GetProductByIdQuery(ProductGetRequestByIdDTO  RequestProductDTO) :  IRequest<Result<GeneralFailure, ProductResponseDTO>>;
    public  record GetAllProductQuery :  IRequest<Result<GeneralFailure, IEnumerable<ProductResponseDTO>>>;
}