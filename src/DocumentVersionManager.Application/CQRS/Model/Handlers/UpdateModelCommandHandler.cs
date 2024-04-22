using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using LanguageExt;
using MediatR;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class UpdateModelCommandHandler : IRequestHandler<UpdateModelCommand, Either<GeneralFailure, int>>
    {
        private readonly ILogger<UpdateModelCommandHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IModelRepository _modelRepository;

        public UpdateModelCommandHandler(ILogger<UpdateModelCommandHandler> logger, IUnitOfWork unitOfWork, IModelRepository modelRepository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _modelRepository = modelRepository;
        }


        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.Model.Create(request.UpdateModelDTO.ModelName, request.UpdateModelDTO.ModelTypesName, Guid.NewGuid());


            //entity.AddDomainEvent(new ModelUpdatedEvent(entity));

            return await _modelRepository.UpdateAsync(entity, cancellationToken);



        }




    }
}
