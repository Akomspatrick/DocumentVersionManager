using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetAllModelVersionGroupQueryHandler : IRequestHandler<GetAllModelVersionGroupQuery, Either<GeneralFailure, IEnumerable<ModelVersionGroupResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllModelVersionGroupQueryHandler> _logger;
        public GetAllModelVersionGroupQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllModelVersionGroupQueryHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ModelVersionGroupResponseDTO>>> Handle(GetAllModelVersionGroupQuery request, CancellationToken cancellationToken)
        {
            return (await _unitOfWork.ModelVersionGroupRepository
                    .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                    .Map(task => task.Select(result => new ModelVersionGroupResponseDTO(result.ModelVersionGroupName, result.DefaultTestingMode, result.Description, result.GuidId)));// ;/);
        }
        //string  ModelVersionGroupName, string  testingMode, string  description, Guid  guidId

        //.GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
        //.Map(task => task.Select(result => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null)));

    }
}
