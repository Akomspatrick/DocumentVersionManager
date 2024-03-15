using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class GetAllModelTypeQueryHandler : IRequestHandler<GetAllModelTypeQuery, Result<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllModelTypeQueryHandler> _logger;
        public GetAllModelTypeQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllModelTypeQueryHandler> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }


        async Task<Result<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>> IRequestHandler<GetAllModelTypeQuery, Result<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>.Handle(GetAllModelTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Work on the IEnumerable version");
            //return (await _unitOfWork.ModelTypeRepository
            //      .GetAllAsync(s => true, new List<string>() { "Models" }, null, cancellationToken))
            //      .Map(task => task
            //     .Select(result => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, ConvertTo(result.Models))));
        }

        private ICollection<ModelResponseDTO> ConvertTo(IEnumerable<Domain.Entities.Model> models)
        {

            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }
    }
}
