
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Logging;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public sealed class CreateModelTypeCommandHandler : IRequestHandler<CreateModelTypeCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateModelTypeCommandHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;


        public CreateModelTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateModelTypeCommandHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelTypeRepository = modelTypeRepository;
        }


        public async Task<Either<GeneralFailure, Guid>> Handle(CreateModelTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.ModelType.Create(request.CreateModelTypeDTO.ModelTypeName, request.CreateModelTypeDTO.GuidId);
            return (await _modelTypeRepository.AddAsync(entity, cancellationToken)).Map((x) => entity.GuidId);
        }

    }
}
