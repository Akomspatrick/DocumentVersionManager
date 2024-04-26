using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteProcessFlowGroupCommandHandler  :  IRequestHandler<DeleteProcessFlowGroupCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository ;
        private readonly ILogger<DeleteProcessFlowGroupCommandHandler> _logger;
        public DeleteProcessFlowGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteProcessFlowGroupCommandHandler> logger, IProcessFlowGroupRepository ProcessFlowGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository  ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteProcessFlowGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _ProcessFlowGroupRepository.DeleteByGuidAsync(request.DeleteProcessFlowGroupDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ProcessFlowGroupRepository.DeleteByGuidAsync(request.DeleteProcessFlowGroupDTO.guid, cancellationToken);
        }
    }
}