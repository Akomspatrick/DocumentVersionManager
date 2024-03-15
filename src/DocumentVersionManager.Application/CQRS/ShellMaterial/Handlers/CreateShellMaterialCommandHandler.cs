using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateShellMaterialCommandHandler  :  IRequestHandler<CreateShellMaterialCommand, Result<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateShellMaterialCommandHandler> _logger;
        public CreateShellMaterialCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateShellMaterialCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, Guid>> Handle(CreateShellMaterialCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ShellMaterial.Create(request.modelTypeCreateDTO.ModelTypeName, request.modelTypeCreateDTO.Value.GuidId);return ( await _unitOfWork.ShellMaterialRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}