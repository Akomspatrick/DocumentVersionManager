using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateProcessFlowGroupCommandHandler  :  IRequestHandler<CreateProcessFlowGroupCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProcessFlowGroupCommandHandler> _logger;
        public IProcessFlowGroupRepository _processFlowGroupRepository ;
        public CreateProcessFlowGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProcessFlowGroupCommandHandler> logger, IProcessFlowGroupRepository processFlowGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _processFlowGroupRepository = processFlowGroupRepository  ?? throw new ArgumentNullException(nameof(processFlowGroupRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProcessFlowGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProcessFlowGroup.Create(request.processFlowGroupCreateDTO.ProcessFlowGroupName, request.processFlowGroupCreateDTO.Value.GuidId);return ( await  _processFlowGroupRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}