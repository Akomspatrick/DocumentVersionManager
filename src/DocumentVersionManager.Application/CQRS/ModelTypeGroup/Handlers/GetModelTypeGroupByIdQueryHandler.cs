using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetModelTypeGroupByIdQueryHandler  :  IRequestHandler<GetModelTypeGroupByIdQuery, Either<GeneralFailure, ModelTypeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelTypeGroupByIdQueryHandler> _logger;
        public GetModelTypeGroupByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelTypeGroupByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ModelTypeGroupResponseDTO>> Handle(GetModelTypeGroupByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}