using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetModelQueryHandler  :  IRequestHandler<GetModelQuery, Result<GeneralFailure, ModelResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelQueryHandler> _logger;
        public GetModelQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, ModelResponseDTO>> Handle(GetModelQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}