using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetAllTestingModeGroupQueryHandler : IRequestHandler<GetAllTestingModeGroupQuery, Either<GeneralFailure, IEnumerable<TestingModeGroupResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllTestingModeGroupQueryHandler> _logger;
        public ITestingModeGroupRepository _testingModeGroupRepository;
        public GetAllTestingModeGroupQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllTestingModeGroupQueryHandler> logger, ITestingModeGroupRepository testingModeGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testingModeGroupRepository = testingModeGroupRepository ?? throw new ArgumentNullException(nameof(testingModeGroupRepository));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TestingModeGroupResponseDTO>>> Handle(GetAllTestingModeGroupQuery request, CancellationToken cancellationToken)
        {
            return (await _testingModeGroupRepository
                   .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                   .Map(task => task.Select(result => new TestingModeGroupResponseDTO(result.TestingModeGroupName, result.DefaultTestingMode, result.Description, result.GuidId)));// ;/);

        }
    }
}