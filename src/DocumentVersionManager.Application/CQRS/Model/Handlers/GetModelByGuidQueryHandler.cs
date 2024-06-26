using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class GetModelByGuidQueryHandler : IRequestHandler<GetModelByGuidQuery, Either<GeneralFailure, ModelResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelByGuidQueryHandler> _logger;
        private readonly IModelRepository _modelRepository;
        public GetModelByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelByGuidQueryHandler> logger, IModelRepository modelRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelRepository = modelRepository;
        }

        public async Task<Either<GeneralFailure, ModelResponseDTO>> Handle(GetModelByGuidQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = new List<string>() { "ModelVersions" };
            return (await _modelRepository
                            .GetMatch(s => s.GuidId == request.RequestModelDTO.guid, includes, cancellationToken))
                            .Map((result) => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null
                            //convertToModelDto(result.Models

                            //)));
                            ));
        }
    }
}