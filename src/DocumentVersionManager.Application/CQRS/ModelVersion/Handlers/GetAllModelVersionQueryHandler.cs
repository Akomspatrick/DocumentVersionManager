using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllModelVersionQueryHandler  :  IRequestHandler<GetAllModelVersionQuery, Either<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllModelVersionQueryHandler> _logger;
        public GetAllModelVersionQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllModelVersionQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelVersionResponseDTO>>> Handle(GetAllModelVersionQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}