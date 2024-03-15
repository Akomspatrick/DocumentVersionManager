using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using MediatR;
using System.Linq.Expressions;

namespace DocumentVersionManager.Application.CQRS.Model.Handlers
{
    public class GetAllModelQueryHandler : IRequestHandler<GetAllModelQuery, Result<GeneralFailure, IEnumerable<ModelResponseDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetAllModelQueryHandler> _logger;
        public GetAllModelQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAllModelQueryHandler> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<GeneralFailure, IEnumerable<ModelResponseDTO>>> Handle(GetAllModelQuery request, CancellationToken cancellationToken)
        {

            //return (await _unitOfWork.ModelRepository
            //        .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
            //        .Map(task => task.Select(result => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null)));

            var x = (await _unitOfWork.ModelRepository
                   .GetAllAsync(s => true, new List<string>() { "ModelVersions" }, null, cancellationToken))
                   .Map(task => task.Select(result => new ModelResponseDTO(result.GuidId, result.ModelName, result.ModelTypeName, null)));
            var p = Task.FromResult<IEnumerable<int>>(x);
            return x;

        }
    }


}
