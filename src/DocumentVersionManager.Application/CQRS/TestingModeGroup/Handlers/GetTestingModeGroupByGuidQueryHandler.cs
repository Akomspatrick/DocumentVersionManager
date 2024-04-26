using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public class GetProcessFlowGroupByGuidQueryHandler : IRequestHandler<GetProcessFlowGroupByGuidQuery, Either<GeneralFailure, ProcessFlowGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProcessFlowGroupByGuidQueryHandler> _logger;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository;
        public GetProcessFlowGroupByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProcessFlowGroupByGuidQueryHandler> logger, IProcessFlowGroupRepository ProcessFlowGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository));
        }

        public async Task<Either<GeneralFailure, ProcessFlowGroupResponseDTO>> Handle(GetProcessFlowGroupByGuidQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = null;// new List<string>() { "Models" };
            return (await _ProcessFlowGroupRepository
                            //==4
                            //.GetMatch(s => s.ModelTypeName == request.modelTypeRequestDTO.Value.ModelTypeId, includes, cancellationToken))
                            //.Map((result) => new ApplicationModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));

                            .GetMatch(s => s.GuidId.Equals(request.RequestProcessFlowGroupDTO.guid), includes, cancellationToken))
                            .Map((result) => new ProcessFlowGroupResponseDTO(result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, result.GuidId));


        }
    }
}