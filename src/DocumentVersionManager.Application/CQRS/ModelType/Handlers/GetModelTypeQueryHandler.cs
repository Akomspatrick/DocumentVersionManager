using Microsoft.Extensions.Logging;

using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.ResponseDTO.V1;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class GetModelTypeQueryHandler : IRequestHandler<GetModelTypeQuery, Either<GeneralFailure, ModelTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelTypeQueryHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;
        public GetModelTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelTypeQueryHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _modelTypeRepository = modelTypeRepository;
        }
        public async Task<Either<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeQuery request, CancellationToken cancellationToken)
        {

            List<string> includes = new List<string>() { "Models" };
            return (await _modelTypeRepository
                    .GetMatch(s => (s.ModelTypeName == request.RequestModelTypeDTO.JSONValue), includes, cancellationToken))
                    .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));

        }

        private ICollection<ModelResponseDTO> convertToModelDto(IEnumerable<Domain.Entities.Model> models)
        {
            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }
    }
}
