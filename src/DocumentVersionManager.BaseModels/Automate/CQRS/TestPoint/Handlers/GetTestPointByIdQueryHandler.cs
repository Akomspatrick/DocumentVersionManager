using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetTestPointByIdQueryHandler  :  IRequestHandler<GetTestPointByIdQuery, Either<GeneralFailure, TestPointResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestPointByIdQueryHandler> _logger;
        public ITestPointRepository _testPointRepository ;
        public GetTestPointByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestPointByIdQueryHandler> logger, ITestPointRepository testPointRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testPointRepository = testPointRepository  ?? throw new ArgumentNullException(nameof(testPointRepository ));
        }

        public async Task<Either<GeneralFailure, TestPointResponseDTO>> Handle(GetTestPointByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}