using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.ResponseDTO.V1;


namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class GetAllModelTypeQueryHandler : IRequestHandler<GetAllModelTypeQuery, Either<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllModelTypeQueryHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;
        public GetAllModelTypeQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllModelTypeQueryHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _modelTypeRepository = modelTypeRepository;
        }


        async Task<Either<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>> IRequestHandler<GetAllModelTypeQuery, Either<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>.Handle(GetAllModelTypeQuery request, CancellationToken cancellationToken)
        {

            return (await _modelTypeRepository
                  .GetAllAsync(s => true, new List<string>() { "Models" }, null, cancellationToken))
                  .Map(task => task
                 .Select(result => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, ConvertTo(result.Models))));
        }

        private ICollection<ModelResponseDTO> ConvertTo(IEnumerable<Domain.Entities.Model> models)
        {

            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }
    }
}
