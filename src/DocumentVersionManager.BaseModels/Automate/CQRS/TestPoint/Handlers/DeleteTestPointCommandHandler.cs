using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace DocumentVersionManager.Application.CQRS
{
    public  class DeleteTestPointCommandHandler  :  IRequestHandler<DeleteTestPointCommand, Either<GeneralFailure, int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ITestPointRepository _testPointRepository ;
        private readonly ILogger<DeleteTestPointCommandHandler> _logger;
        public DeleteTestPointCommandHandler(IUnitOfWork unitOfWork, ILogger<DeleteTestPointCommandHandler> logger, ITestPointRepository testPointRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testPointRepository = testPointRepository  ?? throw new ArgumentNullException(nameof(testPointRepository ));
        }

        public async Task<Either<GeneralFailure, int>> Handle(DeleteTestPointCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("Operation Not Allowed ");
            //return  await _testPointRepository.DeleteByGuidAsync(request.DeleteTestPointDTO.guid, cancellationToken);
            //Old return  await _unitOfWork.TestPointRepository.DeleteByGuidAsync(request.DeleteTestPointDTO.guid, cancellationToken);
        }
    }
}