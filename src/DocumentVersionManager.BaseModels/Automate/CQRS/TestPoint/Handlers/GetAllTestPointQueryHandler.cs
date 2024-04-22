using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllTestPointQueryHandler  :  IRequestHandler<GetAllTestPointQuery, Either<GeneralFailure, IEnumerable<TestPointResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllTestPointQueryHandler> _logger;
        public ITestPointRepository _testPointRepository ;
        public GetAllTestPointQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllTestPointQueryHandler> logger, ITestPointRepository testPointRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testPointRepository = testPointRepository  ?? throw new ArgumentNullException(nameof(testPointRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TestPointResponseDTO>>> Handle(GetAllTestPointQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}