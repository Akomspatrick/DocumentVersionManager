using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public sealed class CreateModelTypeCommandHandler : IRequestHandler<CreateModelTypeCommand, Result<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateModelTypeCommandHandler> _logger;


        public CreateModelTypeCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateModelTypeCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        public async Task<Result<GeneralFailure, Guid>> Handle(CreateModelTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.ModelType.Create(request.CreateModelTypeDTO.ModelTypeName, request.CreateModelTypeDTO.GuidId);
            return (await _unitOfWork.ModelTypeRepository.AddAsync(entity, cancellationToken)).Map((x) => entity.GuidId);
        }

    }
}
