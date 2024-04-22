

namespace DocumentVersionManager.Contracts.ResponseDTO.V1
{
    public record ModelResponseDTO(Guid GuidId, string ModelName, string ModelTypeName, ICollection<ModelVersionResponseDTO>? ModelVersions);

}