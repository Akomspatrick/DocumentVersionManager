using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetProcessFlowGroupByGuidQueryHandler  :  IRequestHandler<GetProcessFlowGroupByGuidQuery, Either<GeneralFailure, ProcessFlowGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProcessFlowGroupByGuidQueryHandler> _logger;
        public IProcessFlowGroupRepository _processFlowGroupRepository ;
        public GetProcessFlowGroupByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProcessFlowGroupByGuidQueryHandler> logger, IProcessFlowGroupRepository processFlowGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _processFlowGroupRepository = processFlowGroupRepository  ?? throw new ArgumentNullException(nameof(processFlowGroupRepository ));
        }

        public async Task<Either<GeneralFailure, ProcessFlowGroupResponseDTO>> Handle(GetProcessFlowGroupByGuidQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}