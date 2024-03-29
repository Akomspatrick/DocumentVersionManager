using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllModelQueryHandler  :  IRequestHandler<GetAllModelQuery, Either<GeneralFailure, IEnumerable<ModelResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllModelQueryHandler> _logger;
        public GetAllModelQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllModelQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelResponseDTO>>> Handle(GetAllModelQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}