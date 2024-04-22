using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateShellMaterialCommandHandler  :  IRequestHandler<CreateShellMaterialCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateShellMaterialCommandHandler> _logger;
        public IShellMaterialRepository _shellMaterialRepository ;
        public CreateShellMaterialCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateShellMaterialCommandHandler> logger, IShellMaterialRepository shellMaterialRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shellMaterialRepository = shellMaterialRepository  ?? throw new ArgumentNullException(nameof(shellMaterialRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateShellMaterialCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.ShellMaterial.Create(request.shellMaterialCreateDTO.ShellMaterialName, request.shellMaterialCreateDTO.Value.GuidId);return ( await  _shellMaterialRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}