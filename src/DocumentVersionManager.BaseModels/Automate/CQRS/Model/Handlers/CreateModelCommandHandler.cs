using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateModelCommandHandler  :  IRequestHandler<CreateModelCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateModelCommandHandler> _logger;
        public IModelRepository _modelRepository ;
        public CreateModelCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateModelCommandHandler> logger, IModelRepository modelRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelRepository = modelRepository  ?? throw new ArgumentNullException(nameof(modelRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.Model.Create(request.modelCreateDTO.ModelName, request.modelCreateDTO.Value.GuidId);return ( await  _modelRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}