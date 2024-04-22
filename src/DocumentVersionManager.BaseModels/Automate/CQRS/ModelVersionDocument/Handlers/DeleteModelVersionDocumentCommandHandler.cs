using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteModelVersionDocumentCommandHandler  :  IRequestHandler<DeleteModelVersionDocumentCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository ;
        private readonly ILogger<DeleteModelVersionDocumentCommandHandler> _logger;
        public DeleteModelVersionDocumentCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelVersionDocumentCommandHandler> logger, IModelVersionDocumentRepository modelVersionDocumentRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionDocumentRepository = modelVersionDocumentRepository  ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelVersionDocumentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _modelVersionDocumentRepository.DeleteByGuidAsync(request.DeleteModelVersionDocumentDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ModelVersionDocumentRepository.DeleteByGuidAsync(request.DeleteModelVersionDocumentDTO.guid, cancellationToken);
        }
    }
}