﻿using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Entities;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class UpdateModelTypeCommandHandler : IRequestHandler<UpdateModelTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IAppLogger<UpdateModelTypeCommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateModelTypeCommandHandler(IAppLogger<UpdateModelTypeCommandHandler> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            var entity = Domain.Entities.ModelType.Create(request.modelTypeUpdateDTO.Value.ModelTypeId, request.modelTypeUpdateDTO.Value.ModelTypeName);
            return await _unitOfWork.ModelTypesRepository.UpdateAsync(entity, cancellationToken);
            //_logger.LogInformation("AddNewModelTypeCommandHandler- New data Added");
        }

        private Domain.Entities.ModelType modify(Domain.Entities.ModelType x, ApplicationModelTypeUpdateDTO modelTypeUpdateDTO)
        {
            return Domain.Entities.ModelType.Create(x.GuidId, modelTypeUpdateDTO.Value.ModelTypeName);
        }
    }
}
