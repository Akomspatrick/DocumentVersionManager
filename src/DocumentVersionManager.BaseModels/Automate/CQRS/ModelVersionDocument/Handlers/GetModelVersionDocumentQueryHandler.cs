using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetModelVersionDocumentQueryHandler  :  IRequestHandler<GetModelVersionDocumentQuery, Either<GeneralFailure, ModelVersionDocumentResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelVersionDocumentQueryHandler> _logger;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository ;
        public GetModelVersionDocumentQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelVersionDocumentQueryHandler> logger, IModelVersionDocumentRepository modelVersionDocumentRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionDocumentRepository = modelVersionDocumentRepository  ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository ));
        }

        public async Task<Either<GeneralFailure, ModelVersionDocumentResponseDTO>> Handle(GetModelVersionDocumentQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}