using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateModelVersionDocumentCommandHandler  :  IRequestHandler<CreateModelVersionDocumentCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateModelVersionDocumentCommandHandler> _logger;
        public IModelVersionDocumentRepository _modelVersionDocumentRepository ;
        public CreateModelVersionDocumentCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateModelVersionDocumentCommandHandler> logger, IModelVersionDocumentRepository modelVersionDocumentRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionDocumentRepository = modelVersionDocumentRepository  ?? throw new ArgumentNullException(nameof(modelVersionDocumentRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateModelVersionDocumentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ModelVersionDocument.Create(request.modelVersionDocumentCreateDTO.ModelVersionDocumentName, request.modelVersionDocumentCreateDTO.Value.GuidId);return ( await  _modelVersionDocumentRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}