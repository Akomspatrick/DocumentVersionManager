using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.ResponseDTO.V1;



namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class GetModelTypeByIdQueryHandler : IRequestHandler<GetModelTypeByIdQuery, Either<GeneralFailure, ModelTypeResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelTypeByIdQueryHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;
        public GetModelTypeByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelTypeByIdQueryHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _modelTypeRepository = modelTypeRepository;
        }

        public async Task<Either<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByIdQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = new List<string>() { "Models" };
            return (await _modelTypeRepository
                            //==4
                            //.GetMatch(s => s.ModelTypeName == request.modelTypeRequestDTO.Value.ModelTypeId, includes, cancellationToken))
                            //.Map((result) => new ApplicationModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));

                            .GetMatch(s => s.ModelTypeName == request.RequestModelTypeDTO.ModelTypeId, includes, cancellationToken))
                            .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
        }

        private ICollection<ModelResponseDTO> convertToModelDto(IReadOnlyCollection<Domain.Entities.Model> models)
        {
            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }

    }
}
