using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using LanguageExt;
using MediatR;
using MediatR;
using AutoMapper;using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
namespace DocumentVersionManager.Application.CQRS
{
    public  class UpdateTestPointCommandHandler  :  IRequestHandler<UpdateTestPointCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateTestPointCommandHandler> _logger;
        public ITestPointRepository _testPointRepository ;
        private readonly IMapper _mapper;
        public UpdateTestPointCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateTestPointCommandHandler> logger, IMapper mapper, ITestPointRepository testPointRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _testPointRepository = testPointRepository  ?? throw new ArgumentNullException(nameof(testPointRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateTestPointCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.TestPoint>(request.UpdateTestPointDTO);
            return await _unitOfWork.TestPointRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}