using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteModelVersionCommandHandler  :  IRequestHandler<DeleteModelVersionCommand, Result<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<DeleteModelVersionCommandHandler> _logger;
        public DeleteModelVersionCommandHandler(IUnitOfWork unitOfWork, IAppLogger<DeleteModelVersionCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Result<GeneralFailure, int>> Handle(DeleteModelVersionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}