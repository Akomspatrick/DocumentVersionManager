using DocumentVersionManager.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public class CreateTestingModeGroupCommandHandler : IRequestHandler<CreateTestingModeGroupCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateTestingModeGroupCommandHandler> _logger;
        public ITestingModeGroupRepository _testingModeGroupRepository;
        public CreateTestingModeGroupCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateTestingModeGroupCommandHandler> logger, ITestingModeGroupRepository testingModeGroupRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testingModeGroupRepository = testingModeGroupRepository ?? throw new ArgumentNullException(nameof(testingModeGroupRepository));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTestingModeGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = Domain.Entities.TestingModeGroup.Create(request.CreateTestingModeGroupDTO.testingModeGroupName, request.CreateTestingModeGroupDTO.defaultTestingMode, request.CreateTestingModeGroupDTO.description, request.CreateTestingModeGroupDTO.guidId);
            return (await _testingModeGroupRepository.AddAsync(entity, cancellationToken)).Map((x) => entity.GuidId);
            // throw new NotImplementedException();
            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.TestingModeGroup.Create(request.testingModeGroupCreateDTO.TestingModeGroupName, request.testingModeGroupCreateDTO.Value.GuidId);return ( await  _testingModeGroupRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}