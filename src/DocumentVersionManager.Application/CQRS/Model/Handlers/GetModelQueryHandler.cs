﻿using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Contracts.ResponseDTO.V1;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class GetModelQueryHandler : IRequestHandler<GetModelQuery, Either<GeneralFailure, ModelResponseDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetModelQueryHandler> _logger;
        public GetModelQueryHandler(IUnitOfWork unitOfWork, ILogger<GetModelQueryHandler> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<Either<GeneralFailure, ModelResponseDTO>> Handle(GetModelQuery request, CancellationToken cancellationToken)
        {

            return (await _unitOfWork.ModelRepository
                    .GetMatch(s => (s.ModelName == request.RequestModelDTO.ModelName), null, cancellationToken))
                    .Map((result) => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null));
        }

    }
}
