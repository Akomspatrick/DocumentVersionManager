using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.ResponseDTO.V1;


namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class GetModelTypeByGuidQueryHandler : IRequestHandler<GetModelTypeByGuidQuery, Either<GeneralFailure, ModelTypeResponseDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelTypeByGuidQueryHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;
        public GetModelTypeByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelTypeByGuidQueryHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _modelTypeRepository = modelTypeRepository;
        }
        public async Task<Either<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByGuidQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = new List<string>() { "Models" };
            return (await _modelTypeRepository
                            .GetMatch(s => s.GuidId == request.RequestModelTypeDTO.ModelTypeId, includes, cancellationToken))
                            .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
        }

        private ICollection<ModelResponseDTO> convertToModelDto(IReadOnlyCollection<Domain.Entities.Model> models)
        {
            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }
    }
}
