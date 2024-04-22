using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateModelVersionCommandHandler  :  IRequestHandler<CreateModelVersionCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateModelVersionCommandHandler> _logger;
        public IModelVersionRepository _modelVersionRepository ;
        public CreateModelVersionCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateModelVersionCommandHandler> logger, IModelVersionRepository modelVersionRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelVersionRepository = modelVersionRepository  ?? throw new ArgumentNullException(nameof(modelVersionRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateModelVersionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ModelVersion.Create(request.modelVersionCreateDTO.ModelVersionName, request.modelVersionCreateDTO.Value.GuidId);return ( await  _modelVersionRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}