using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllModelTypeQueryHandler  :  IRequestHandler<GetAllModelTypeQuery, Either<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllModelTypeQueryHandler> _logger;
        public IModelTypeRepository _modelTypeRepository ;
        public GetAllModelTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllModelTypeQueryHandler> logger, IModelTypeRepository modelTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelTypeRepository = modelTypeRepository  ?? throw new ArgumentNullException(nameof(modelTypeRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>> Handle(GetAllModelTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}