using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetTestingModeGroupByIdQueryHandler  :  IRequestHandler<GetTestingModeGroupByIdQuery, Either<GeneralFailure, TestingModeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestingModeGroupByIdQueryHandler> _logger;
        public ITestingModeGroupRepository _testingModeGroupRepository ;
        public GetTestingModeGroupByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestingModeGroupByIdQueryHandler> logger, ITestingModeGroupRepository testingModeGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testingModeGroupRepository = testingModeGroupRepository  ?? throw new ArgumentNullException(nameof(testingModeGroupRepository ));
        }

        public async Task<Either<GeneralFailure, TestingModeGroupResponseDTO>> Handle(GetTestingModeGroupByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}