using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    public class DeleteModelTypeCommandHandler : IRequestHandler<DeleteModelTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteModelTypeCommandHandler> _logger;
        private readonly IModelTypeRepository _modelTypeRepository;

        public DeleteModelTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteModelTypeCommandHandler> logger, IModelTypeRepository modelTypeRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _modelTypeRepository = modelTypeRepository;
        }


        public async Task<Either<GeneralFailure, int>> Handle(DeleteModelTypeCommand request, CancellationToken cancellationToken)
        {
            return (
                await _modelTypeRepository
                .GetMatch(s => (s.GuidId.Equals(request.DeleteModelTypeDTO.guid)), null, cancellationToken))
                .Match(Left: x => x, Right: x => _modelTypeRepository
                .DeleteAsync(x, cancellationToken)
                .Result);

            ////   return (
            //var res = await _modelTypeRepository
            // .GetMatch(s => (s.GuidId.Equals(request.DeleteModelTypeDTO.guid)), null, cancellationToken);
            //var dd=
            //res.Match(Left: x => x, Right: x => _modelTypeRepository
            //.DeleteAsync(x, cancellationToken)
            //.Result);
        }


    }
}
