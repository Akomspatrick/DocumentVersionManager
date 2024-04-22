using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteModelTypeCommandHandler  :  IRequestHandler<DeleteModelTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IModelTypeRepository _modelTypeRepository ;
        private readonly ILogger<DeleteModelTypeCommandHandler> _logger;
        public DeleteModelTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelTypeCommandHandler> logger, IModelTypeRepository modelTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelTypeRepository = modelTypeRepository  ?? throw new ArgumentNullException(nameof(modelTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _modelTypeRepository.DeleteByGuidAsync(request.DeleteModelTypeDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ModelTypeRepository.DeleteByGuidAsync(request.DeleteModelTypeDTO.guid, cancellationToken);
        }
    }
}