using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetModelVersionGroupQueryHandler : IRequestHandler<GetModelVersionGroupQuery, Either<GeneralFailure, ModelVersionGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelVersionGroupQueryHandler> _logger;
        public GetModelVersionGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelVersionGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ModelVersionGroupResponseDTO>> Handle(GetModelVersionGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //   return (await _unitOfWork.ModelVersionGroupRepository.GetMatch(s => (s.ModelVersionGroupName == request.RequestModelVersionGroupDTO.ModelVersionGroupName), null, cancellationToken)).
            //     Map((result) => new ModelVersionGroupResponseDTO(result.GuidId, result.ModelVersionGroupName, null));


            //    .GetMatch(s => (s.ModelName == request.RequestModelDTO.ModelName), null, cancellationToken))
            //  .Map((result) => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null));

        }
    }
}