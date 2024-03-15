﻿using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class DeleteModelTypeCommandHandler : IRequestHandler<DeleteModelTypeCommand, Result<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteModelTypeCommandHandler> _logger;

        public DeleteModelTypeCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteModelTypeCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }


        public async Task<Result<GeneralFailure, int>> Handle(DeleteModelTypeCommand request, CancellationToken cancellationToken)
        {
            return (
                await _unitOfWork.ModelTypeRepository
                .GetMatch(s => (s.GuidId.Equals(request.DeleteModelTypeDTO.guid)), null, cancellationToken))
                .Match(x => _unitOfWork.ModelTypeRepository
                .DeleteAsync(x, cancellationToken)
                .Result, x => x);

        }


    }
}
