using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.RequestDTO.V1;


namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class UpdateModelTypeCommandHandler : IRequestHandler<UpdateModelTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly ILogger<UpdateModelTypeCommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IModelTypeRepository _modelTypeRepository;
        public UpdateModelTypeCommandHandler(ILogger<UpdateModelTypeCommandHandler> logger, IUnitOfWork unitOfWork, IModelTypeRepository modelTypeRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _modelTypeRepository = modelTypeRepository;
        }
        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            var entity = Domain.Entities.ModelType.Create(request.UpdateModelTypeDTO.ModelTypeName, request.UpdateModelTypeDTO.ProcessFlowGroupName, request.UpdateModelTypeDTO.ModelTypeId);
            return await _modelTypeRepository.UpdateAsync(entity, cancellationToken);
            //_logger.LogInformation("AddNewModelTypeCommandHandler- New data Added");
        }

        private Domain.Entities.ModelType modify(Domain.Entities.ModelType x, ModelTypeUpdateRequestDTO modelTypeUpdateDTO)
        {
            return Domain.Entities.ModelType.Create(modelTypeUpdateDTO.ModelTypeName, modelTypeUpdateDTO.ProcessFlowGroupName, x.GuidId);
        }
    }
}
