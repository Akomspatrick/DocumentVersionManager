using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteTestingModeGroupCommandHandler  :  IRequestHandler<DeleteTestingModeGroupCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ITestingModeGroupRepository _testingModeGroupRepository ;
        private readonly ILogger<DeleteTestingModeGroupCommandHandler> _logger;
        public DeleteTestingModeGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteTestingModeGroupCommandHandler> logger, ITestingModeGroupRepository testingModeGroupRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testingModeGroupRepository = testingModeGroupRepository  ?? throw new ArgumentNullException(nameof(testingModeGroupRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteTestingModeGroupCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _testingModeGroupRepository.DeleteByGuidAsync(request.DeleteTestingModeGroupDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.TestingModeGroupRepository.DeleteByGuidAsync(request.DeleteTestingModeGroupDTO.guid, cancellationToken);
        }
    }
}