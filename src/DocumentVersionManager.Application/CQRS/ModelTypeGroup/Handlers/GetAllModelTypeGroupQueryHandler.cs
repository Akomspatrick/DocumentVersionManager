using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetAllTestingModeGroupQueryHandler : IRequestHandler<GetAllTestingModeGroupQuery, Either<GeneralFailure, IEnumerable<TestingModeGroupResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllTestingModeGroupQueryHandler> _logger;
        public GetAllTestingModeGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllTestingModeGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<TestingModeGroupResponseDTO>>> Handle(GetAllTestingModeGroupQuery request, CancellationToken cancellationToken)
        {
            return (await _unitOfWork.TestingModeGroupRepository
                    .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                    .Map(task => task.Select(result => new TestingModeGroupResponseDTO(result.TestingModeGroupName, result.DefaultTestingMode, result.Description, result.GuidId)));// ;/);
        }
        //string  TestingModeGroupName, string  testingMode, string  description, Guid  guidId

        //.GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
        //.Map(task => task.Select(result => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null)));

    }
}
