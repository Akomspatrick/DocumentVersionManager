using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public  class CreateTestPointCommandHandler  :  IRequestHandler<CreateTestPointCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTestPointCommandHandler> _logger;
        public ITestPointRepository _testPointRepository ;
        public CreateTestPointCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTestPointCommandHandler> logger, ITestPointRepository testPointRepository )
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testPointRepository = testPointRepository  ?? throw new ArgumentNullException(nameof(testPointRepository ));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTestPointCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.TestPoint.Create(request.testPointCreateDTO.TestPointName, request.testPointCreateDTO.Value.GuidId);return ( await  _testPointRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}