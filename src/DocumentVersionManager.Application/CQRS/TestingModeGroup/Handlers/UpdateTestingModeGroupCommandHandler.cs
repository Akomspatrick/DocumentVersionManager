using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
namespace DocumentVersionManager.Application.CQRS
{
    public class UpdateProcessFlowGroupCommandHandler : IRequestHandler<UpdateProcessFlowGroupCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateProcessFlowGroupCommandHandler> _logger;
        public IProcessFlowGroupRepository _ProcessFlowGroupRepository;
        private readonly IMapper _mapper;
        public UpdateProcessFlowGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateProcessFlowGroupCommandHandler> logger, IMapper mapper, IProcessFlowGroupRepository ProcessFlowGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _ProcessFlowGroupRepository = ProcessFlowGroupRepository ?? throw new ArgumentNullException(nameof(ProcessFlowGroupRepository));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateProcessFlowGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ProcessFlowGroup>(request.UpdateProcessFlowGroupDTO);
            return await _ProcessFlowGroupRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}