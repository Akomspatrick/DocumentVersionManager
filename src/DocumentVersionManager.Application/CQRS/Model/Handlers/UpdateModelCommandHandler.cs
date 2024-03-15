﻿using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class UpdateModelCommandHandler : IRequestHandler<UpdateModelCommand, Result<GeneralFailure, int>>
    {
        private readonly IAppLogger<UpdateModelCommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateModelCommandHandler(IAppLogger<UpdateModelCommandHandler> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }


        public async Task<Result<GeneralFailure, int>> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.Model.Create(request.UpdateModelDTO.ModelName, request.UpdateModelDTO.ModelTypesName, Guid.NewGuid());


            //entity.AddDomainEvent(new ModelUpdatedEvent(entity));

            return await _unitOfWork.ModelRepository.UpdateAsync(entity, cancellationToken);



        }




    }
}
