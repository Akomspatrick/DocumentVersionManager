namespace DocumentVersionManager.Contracts.ResponseDTO
{

    // public record ModelResponseDTO(Guid GuidId, string ModelName, string ModelTypesName);
    //result.GuidId, result.ModelTypeName, result.ModelTypes.Select(x => new ModelTypeResponseDTO(x.GuidId, x.ModelTypeName, x.Value)))));        } 
    public record ModelVersionGroupResponseDTO(string ModelVersionGroupName, string testingMode, string description, Guid guidId);
}