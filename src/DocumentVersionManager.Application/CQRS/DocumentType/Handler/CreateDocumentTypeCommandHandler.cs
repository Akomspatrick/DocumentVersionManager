﻿
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.DocumentType.Commands;
using DocumentVersionManager.Application.CQRS.ModelType.Handlers;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.DocumentType.Handler
{
    public class CreateDocumentTypeCommandHandler : IRequestHandler<CreateDocumentTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateModelTypeCommandHandler> _logger;

        public CreateDocumentTypeCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateModelTypeCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, int>> Handle(CreateDocumentTypeCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.DocumentType.Create(Guid.NewGuid(), request.documentTypeName.DocumentTypeName);

            return await _unitOfWork.DocumentTypeRepository.AddAsync(entity, cancellationToken);

        }

    }
}
