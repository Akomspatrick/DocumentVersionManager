using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetTestingModeGroupQueryHandler : IRequestHandler<GetTestingModeGroupQuery, Either<GeneralFailure, TestingModeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetTestingModeGroupQueryHandler> _logger;
        public GetTestingModeGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetTestingModeGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, TestingModeGroupResponseDTO>> Handle(GetTestingModeGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //   return (await _unitOfWork.TestingModeGroupRepository.GetMatch(s => (s.TestingModeGroupName == request.RequestTestingModeGroupDTO.TestingModeGroupName), null, cancellationToken)).
            //     Map((result) => new TestingModeGroupResponseDTO(result.GuidId, result.TestingModeGroupName, null));


            //    .GetMatch(s => (s.ModelName == request.RequestModelDTO.ModelName), null, cancellationToken))
            //  .Map((result) => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null));

        }
    }
}