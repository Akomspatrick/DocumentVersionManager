using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
namespace DocumentVersionManager.Application.CQRS
{
    public  class UpdateModelCommandHandler  :  IRequestHandler<UpdateModelCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateModelCommandHandler> _logger;
        public IModelRepository _modelRepository ;
        private readonly IMapper _mapper;
        public UpdateModelCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateModelCommandHandler> logger, IMapper mapper, IModelRepository modelRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _modelRepository = modelRepository  ?? throw new ArgumentNullException(nameof(modelRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.Model>(request.UpdateModelDTO);
            return await _modelRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}