using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetModelVersionDocumentByIdQueryHandler  :  IRequestHandler<GetModelVersionDocumentByIdQuery, Result<GeneralFailure, ModelVersionDocumentResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelVersionDocumentByIdQueryHandler> _logger;
        public GetModelVersionDocumentByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelVersionDocumentByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, ModelVersionDocumentResponseDTO>> Handle(GetModelVersionDocumentByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}