using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllModelVersionDocumentQueryHandler  :  IRequestHandler<GetAllModelVersionDocumentQuery, Either<GeneralFailure, IEnumerable<ModelVersionDocumentResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllModelVersionDocumentQueryHandler> _logger;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository ;
        public GetAllModelVersionDocumentQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllModelVersionDocumentQueryHandler> logger, IModelVersionDocumentRepository modelVersionDocumentRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionDocumentRepository = modelVersionDocumentRepository  ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelVersionDocumentResponseDTO>>> Handle(GetAllModelVersionDocumentQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}