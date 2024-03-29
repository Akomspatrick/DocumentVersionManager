using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Application.Contracts.Logging;
using LanguageExt;
using MediatR;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Application.CQRS
{
    public class CreateTestingModeGroupCommandHandler : IRequestHandler<CreateTestingModeGroupCommand, Either<GeneralFailure, Guid>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<CreateTestingModeGroupCommandHandler> _logger;
        public CreateTestingModeGroupCommandHandler(IUnitOfWork unitOfWork, IAppLogger<CreateTestingModeGroupCommandHandler> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Either<GeneralFailure, Guid>> Handle(CreateTestingModeGroupCommand request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException("CreateTestingModeGroupCommand Not Yet Implemented");


            var entity = Domain.Entities.TestingModeGroup.Create(request.CreateTestingModeGroupDTO.TestingModeGroupName, request.CreateTestingModeGroupDTO.testingMode, request.CreateTestingModeGroupDTO.description, request.CreateTestingModeGroupDTO.guidId);
            return (await _unitOfWork.TestingModeGroupRepository.AddAsync(entity, cancellationToken)).Map((x) => entity.GuidId);

            //Follow the format below , initial the entity variable by calling the entity Create method;
        }//var entity =null; Domain.Entities.TestingModeGroup.Create(request.modelTypeCreateDTO.ModelTypeName, request.modelTypeCreateDTO.Value.GuidId);return ( await _unitOfWork.TestingModeGroupRepository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);
    }
}