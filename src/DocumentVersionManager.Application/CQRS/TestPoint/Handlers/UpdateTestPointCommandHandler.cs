using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO;
namespace DocumentVersionManager.Application.CQRS
{
    public  class UpdateTestPointCommandHandler  :  IRequestHandler<UpdateTestPointCommand, Result<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<UpdateTestPointCommandHandler> _logger;
        public UpdateTestPointCommandHandler(IUnitOfWork unitOfWork, IAppLogger<UpdateTestPointCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, int>> Handle(UpdateTestPointCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}