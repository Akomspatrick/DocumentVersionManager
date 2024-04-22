using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class GetAllShellMaterialQueryHandler  :  IRequestHandler<GetAllShellMaterialQuery, Either<GeneralFailure, IEnumerable<ShellMaterialResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllShellMaterialQueryHandler> _logger;
        public IShellMaterialRepository _shellMaterialRepository ;
        public GetAllShellMaterialQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllShellMaterialQueryHandler> logger, IShellMaterialRepository shellMaterialRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _shellMaterialRepository = shellMaterialRepository  ?? throw new ArgumentNullException(nameof(shellMaterialRepository ));
        }

        public async Task<Either<GeneralFailure, IEnumerable<ShellMaterialResponseDTO>>> Handle(GetAllShellMaterialQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}