using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public class CreateProcessFlowGroupCommandHandler : IRequestHandler<CreateProcessFlowGroupCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateProcessFlowGroupCommandHandler> _logger;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository;
        public CreateProcessFlowGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateProcessFlowGroupCommandHandler> logger, IProcessFlowGroupRepository ProcessFlowGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateProcessFlowGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.ProcessFlowGroup.Create(request.CreateProcessFlowGroupDTO.ProcessFlowGroupName, request.CreateProcessFlowGroupDTO.defaultTestingMode, request.CreateProcessFlowGroupDTO.description, request.CreateProcessFlowGroupDTO.guidId);
            return (await _ProcessFlowGroupRepository.AddAsync(entity, cancellationToken)).Map((x) => entity.GuidId);
            // throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ProcessFlowGroup.Create(request.ProcessFlowGroupCreateDTO.ProcessFlowGroupName, request.ProcessFlowGroupCreateDTO.Value.GuidId);return ( await  _ProcessFlowGroupRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}