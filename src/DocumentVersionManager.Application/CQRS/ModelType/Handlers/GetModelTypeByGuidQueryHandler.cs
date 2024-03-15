using DocumentVersionManager.Application.Contracts.Logging;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.DomainBase.Result;
using DocumentVersionManager.DomainBase.Result;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;


namespace DocumentVersionManager.Application.CQRS.ModelType.Handlers
{
    //public class GetModelTypeByGuidQueryHandler : IRequestHandler<GetModelTypeByGuidQuery, Result<GeneralFailure, ModelTypeResponseDTO>>
    //{

    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IAppLogger<GetModelTypeByGuidQueryHandler> _logger;

    //    public GetModelTypeByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelTypeByGuidQueryHandler> logger)
    //    {
    //        _logger = logger;
    //        _unitOfWork = unitOfWork;
    //    }
    //    //public async Task<Result<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByGuidQuery request, CancellationToken cancellationToken)
    //    //{
    //    //    List<string> includes = new List<string>() { "Models" };
    //    //    return (await _unitOfWork.ModelTypeRepository
    //    //                    .GetMatch(s => s.GuidId == request.RequestModelTypeDTO.ModelTypeId, includes, cancellationToken))
    //    //                    .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
    //    //}
    //    public async Task<Result<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByGuidQuery request, CancellationToken cancellationToken)
    //    {
    //        List<string> includes = new List<string>() { "Models" };
    //        return (await _unitOfWork.ModelTypeRepository
    //                        .GetMatch(s => s.GuidId == request.RequestModelTypeDTO.ModelTypeId, includes, cancellationToken))
    //                        .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
    //    }
    //    private ICollection<ModelResponseDTO> convertToModelDto(IReadOnlyCollection<Domain.Entities.Model> models)
    //    {
    //        return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
    //    }
    //}
    public class GetModelTypeByGuidQueryHandler : IRequestHandler<GetModelTypeByGuidQuery, Result<GeneralFailure, ModelTypeResponseDTO>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IAppLogger<GetModelTypeByGuidQueryHandler> _logger;

        public GetModelTypeByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetModelTypeByGuidQueryHandler> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<Result<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByGuidQuery request, CancellationToken cancellationToken)
        {
            List<string> includes = new List<string>() { "Models" };
            return (await _unitOfWork.ModelTypeRepository
                            .GetMatch(s => s.GuidId == request.RequestModelTypeDTO.ModelTypeId, includes, cancellationToken))
                            .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
        }
        //public async Task<Result<GeneralFailure, ModelTypeResponseDTO>> Handle(GetModelTypeByGuidQuery request, CancellationToken cancellationToken)
        //{
        //    List<string> includes = new List<string>() { "Models" };
        //    return (await _unitOfWork.ModelTypeRepository
        //                    .GetByGuidAsync2(request.RequestModelTypeDTO.ModelTypeId, cancellationToken))
        //                    .Map((result) => new ModelTypeResponseDTO(result.GuidId, result.ModelTypeName, convertToModelDto(result.Models)));
        //}
        private ICollection<ModelResponseDTO> convertToModelDto(IReadOnlyCollection<Domain.Entities.Model> models)
        {
            return models.Select(x => new ModelResponseDTO(x.GuidId, x.ModelName, x.ModelTypeName, null)).ToList();
        }
    }
}
