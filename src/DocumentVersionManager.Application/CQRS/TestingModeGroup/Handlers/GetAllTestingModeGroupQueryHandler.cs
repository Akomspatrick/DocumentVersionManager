using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetAllProcessFlowGroupQueryHandler : IRequestHandler<GetAllProcessFlowGroupQuery, Either<GeneralFailure, IEnumerable<ProcessFlowGroupResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProcessFlowGroupQueryHandler> _logger;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository;
        public GetAllProcessFlowGroupQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProcessFlowGroupQueryHandler> logger, IProcessFlowGroupRepository ProcessFlowGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProcessFlowGroupResponseDTO>>> Handle(GetAllProcessFlowGroupQuery request, CancellationToken cancellationToken)
        {
            return (await _ProcessFlowGroupRepository
                   .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                   .Map(task => task.Select(result => new ProcessFlowGroupResponseDTO(result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, result.GuidId)));// ;/);

        }
    }
}