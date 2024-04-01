using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using DocumentVersionManager.Contracts.ResponseDTO.V1;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class GetAllModelQueryHandler : IRequestHandler<GetAllModelQuery, Either<GeneralFailure, IEnumerable<ModelResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
       // private readonly ILogger<GetAllModelQueryHandler> _logger;
        private readonly ILogger<GetAllModelQueryHandler> _logger;
        public GetAllModelQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllModelQueryHandler> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<Either<GeneralFailure, IEnumerable<ModelResponseDTO>>> Handle(GetAllModelQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetAllModelQueryHandler - Handle - Start {0} for {1}",DateTime.UtcNow,nameof(GetAllModelQueryHandler));
            return (await _unitOfWork.ModelRepository
                    .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                    .Map(task => task.Select(result => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null)));
        }
    }


}
