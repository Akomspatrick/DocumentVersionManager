using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
namespace DocumentVersionManager.Application.CQRS
{
    public  class UpdateModelTypeCommandHandler  :  IRequestHandler<UpdateModelTypeCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateModelTypeCommandHandler> _logger;
        public IModelTypeRepository _modelTypeRepository ;
        private readonly IMapper _mapper;
        public UpdateModelTypeCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateModelTypeCommandHandler> logger, IMapper mapper, IModelTypeRepository modelTypeRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _modelTypeRepository = modelTypeRepository  ?? throw new ArgumentNullException(nameof(modelTypeRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateModelTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.ModelType>(request.UpdateModelTypeDTO);
            return await _modelTypeRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}