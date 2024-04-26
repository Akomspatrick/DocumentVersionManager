namespace DocumentVersionManager.Contracts.ResponseDTO.V1
{
    // public  record ProcessFlowGroupResponseDTO(Object Value);
    public record ProcessFlowGroupResponseDTO(string ProcessFlowGroupName, string testingMode, string description, Guid guidId);
}