using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteShellMaterialCommandHandler  :  IRequestHandler<DeleteShellMaterialCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public IShellMaterialRepository _shellMaterialRepository ;
        private readonly ILogger<DeleteShellMaterialCommandHandler> _logger;
        public DeleteShellMaterialCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteShellMaterialCommandHandler> logger, IShellMaterialRepository shellMaterialRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shellMaterialRepository = shellMaterialRepository  ?? throw new ArgumentNullException(nameof(shellMaterialRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteShellMaterialCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _shellMaterialRepository.DeleteByGuidAsync(request.DeleteShellMaterialDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.ShellMaterialRepository.DeleteByGuidAsync(request.DeleteShellMaterialDTO.guid, cancellationToken);
        }
    }
}