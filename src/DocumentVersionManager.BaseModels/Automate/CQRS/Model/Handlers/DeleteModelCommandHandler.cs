using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteModelCommandHandler  :  IRequestHandler<DeleteModelCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IModelRepository _modelRepository ;
        private readonly ILogger<DeleteModelCommandHandler> _logger;
        public DeleteModelCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelCommandHandler> logger, IModelRepository modelRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelRepository = modelRepository  ?? throw new ArgumentNullException(nameof(modelRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _modelRepository.DeleteByGuidAsync(request.DeleteModelDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ModelRepository.DeleteByGuidAsync(request.DeleteModelDTO.guid, cancellationToken);
        }
    }
}