using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1.auto;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetTestingModeGroupByGuidQueryHandler : IRequestHandler<GetTestingModeGroupByGuidQuery, Either<GeneralFailure, TestingModeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetTestingModeGroupByGuidQueryHandler> _logger;
        private readonly ITestingModeGroupRepository _testingModeGroupRepository;
        public GetTestingModeGroupByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetTestingModeGroupByGuidQueryHandler> logger, ITestingModeGroupRepository testingModeGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testingModeGroupRepository = testingModeGroupRepository;
        }

        public async Task<Either<GeneralFailure, TestingModeGroupResponseDTO>> Handle(GetTestingModeGroupByGuidQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = null;// new List<string>() { "Models" };
            return (await _testingModeGroupRepository
                            //==4
                            //.GetMatch(s => s.ModelTypeName == request.modelTypeRequestDTO.Value.ModelTypeId, includes, cancellationToken))
                            //.Map((result) => new ApplicationModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));

                            .GetMatch(s => s.GuidId.Equals(request.RequestTestingModeGroupDTO.guid), includes, cancellationToken))
                            .Map((result) => new TestingModeGroupResponseDTO(result.TestingModeGroupName, result.DefaultTestingMode, result.Description, result.GuidId));

        }
    }
}