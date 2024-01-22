using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetModelTypeGroupQueryHandler : IRequestHandler<GetModelTypeGroupQuery, Either<GeneralFailure, ModelTypeGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelTypeGroupQueryHandler> _logger;
        public GetModelTypeGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelTypeGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, ModelTypeGroupResponseDTO>> Handle(GetModelTypeGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //   return (await _unitOfWork.ModelTypeGroupRepository.GetMatch(s => (s.ModelTypeGroupName == request.RequestModelTypeGroupDTO.ModelTypeGroupName), null, cancellationToken)).
            //     Map((result) => new ModelTypeGroupResponseDTO(result.GuidId, result.ModelTypeGroupName, null));


            //    .GetMatch(s => (s.ModelName == request.RequestModelDTO.ModelName), null, cancellationToken))
            //  .Map((result) => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null));

        }
    }
}