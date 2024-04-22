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
    public class UpdateModelVersionDocumentCommandHandler : IRequestHandler<UpdateModelVersionDocumentCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateModelVersionDocumentCommandHandler> _logger;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository;
        private readonly IMapper _mapper;
        public UpdateModelVersionDocumentCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateModelVersionDocumentCommandHandler> logger, IMapper mapper, IModelVersionDocumentRepository modelVersionDocumentRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _modelVersionDocumentRepository = modelVersionDocumentRepository ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelVersionDocumentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ModelVersionDocument>(request.UpdateModelVersionDocumentDTO);
            return await _modelVersionDocumentRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}