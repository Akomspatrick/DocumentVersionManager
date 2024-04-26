using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetProcessFlowGroupQueryHandler  :  IRequestHandler<GetProcessFlowGroupQuery, Either<GeneralFailure, ProcessFlowGroupResponseDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetProcessFlowGroupQueryHandler> _logger;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository ;
        public GetProcessFlowGroupQueryHandler(IUnitOfWork unitOfWork, ILogger<GetProcessFlowGroupQueryHandler> logger, IProcessFlowGroupRepository ProcessFlowGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository  ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository ));
        }

        public async Task<Either<GeneralFailure, ProcessFlowGroupResponseDTO>> Handle(GetProcessFlowGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}