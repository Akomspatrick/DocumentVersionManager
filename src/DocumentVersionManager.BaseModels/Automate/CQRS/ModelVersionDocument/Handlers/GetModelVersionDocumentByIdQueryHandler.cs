using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetModelVersionDocumentByIdQueryHandler  :  IRequestHandler<GetModelVersionDocumentByIdQuery, Either<GeneralFailure, ModelVersionDocumentResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelVersionDocumentByIdQueryHandler> _logger;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository ;
        public GetModelVersionDocumentByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelVersionDocumentByIdQueryHandler> logger, IModelVersionDocumentRepository modelVersionDocumentRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionDocumentRepository = modelVersionDocumentRepository  ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository ));
        }

        public async Task<Either<GeneralFailure, ModelVersionDocumentResponseDTO>> Handle(GetModelVersionDocumentByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}