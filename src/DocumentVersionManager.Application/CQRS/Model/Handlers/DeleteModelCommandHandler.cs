using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;
using Microsoft.Extensions.Logging;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class DeleteModelCommandHandler : IRequestHandler<DeleteModelCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteModelCommandHandler> _logger;
        private readonly IModelRepository _modelRepository;
        public DeleteModelCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelCommandHandler> logger, IModelRepository modelRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelRepository = modelRepository;
        }
        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
        {
            return (
                  await _modelRepository
                  .GetMatch(s => (s.GuidId == request.DeleteModelDTO.guid), null, cancellationToken))
                  .Match(Left: x => x, Right: x => _modelRepository
                  .DeleteAsync(x, cancellationToken)
                  .Result);
        }


    }
}
