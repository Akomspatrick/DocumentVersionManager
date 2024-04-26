using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllProcessFlowGroupQueryHandler  :  IRequestHandler<GetAllProcessFlowGroupQuery, Either<GeneralFailure, IEnumerable<ProcessFlowGroupResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllProcessFlowGroupQueryHandler> _logger;
        public IProcessFlowGroupRepository _processFlowGroupRepository ;
        public GetAllProcessFlowGroupQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllProcessFlowGroupQueryHandler> logger, IProcessFlowGroupRepository processFlowGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _processFlowGroupRepository = processFlowGroupRepository  ?? throw new ArgumentNullException(nameof(processFlowGroupRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ProcessFlowGroupResponseDTO>>> Handle(GetAllProcessFlowGroupQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}