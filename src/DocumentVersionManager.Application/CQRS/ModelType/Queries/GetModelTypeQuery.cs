
using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
namespace DocumentVersionManager.Application.CQRS.ModelType.Queries
{
    public record GetModelTypeQuery(ModelTypeGetRequestDTO RequestModelTypeDTO) : IRequest<Result<GeneralFailure, ModelTypeResponseDTO>>;
    //public record GetModelTypeByGuidQuery(ModelTypeGetRequestByGuidDTO RequestModelTypeDTO) : IRequest<Result<GeneralFailure, ModelTypeResponseDTO>>;
    public record GetModelTypeByGuidQuery(ModelTypeGetRequestByGuidDTO RequestModelTypeDTO) : IRequest<Result<GeneralFailure, ModelTypeResponseDTO>>;

    public record GetModelTypeByIdQuery(ModelTypeGetRequestByIdDTO RequestModelTypeDTO) : IRequest<Result<GeneralFailure, ModelTypeResponseDTO>>;
    public record GetAllModelTypeQuery : IRequest<Result<GeneralFailure, IEnumerable<ModelTypeResponseDTO>>>;
}