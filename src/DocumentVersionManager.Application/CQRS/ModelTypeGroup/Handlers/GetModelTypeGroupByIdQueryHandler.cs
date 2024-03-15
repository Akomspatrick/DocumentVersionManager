using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetTestingModeGroupByIdQueryHandler : IRequestHandler<GetTestingModeGroupByIdQuery, Result<GeneralFailure, TestingModeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTestingModeGroupByIdQueryHandler> _logger;
        public GetTestingModeGroupByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTestingModeGroupByIdQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, TestingModeGroupResponseDTO>> Handle(GetTestingModeGroupByIdQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = null;// new List<string>() { "Models" };
            return (await _unitOfWork.TestingModeGroupRepository
                            //==4
                            //.GetMatch(s => s.ModelTypeName == request.modelTypeRequestDTO.Value.ModelTypeId, includes, cancellationToken))
                            //.Map((result) => new ApplicationModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));

                            .GetMatch(s => s.TestingModeGroupName.Equals(request.RequestTestingModeGroupDTO.TestingModeGroupName), includes, cancellationToken))
                            .Map((result) => new TestingModeGroupResponseDTO(result.TestingModeGroupName, result.DefaultTestingMode, result.Description, result.GuidId));

        }
    }
}