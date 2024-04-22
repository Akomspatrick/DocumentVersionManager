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
    public  class UpdateTestingModeGroupCommandHandler  :  IRequestHandler<UpdateTestingModeGroupCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateTestingModeGroupCommandHandler> _logger;
        public ITestingModeGroupRepository _testingModeGroupRepository ;
        private readonly IMapper _mapper;
        public UpdateTestingModeGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<UpdateTestingModeGroupCommandHandler> logger, IMapper mapper, ITestingModeGroupRepository testingModeGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _testingModeGroupRepository = testingModeGroupRepository  ?? throw new ArgumentNullException(nameof(testingModeGroupRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(UpdateTestingModeGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("OPERATION NOT ALLOWED");
            var entity = _mapper.Map<Domain.Entities.TestingModeGroup>(request.UpdateTestingModeGroupDTO);
            return await _unitOfWork.TestingModeGroupRepository.UpdateAsync(entity, cancellationToken);
        }
    }
}