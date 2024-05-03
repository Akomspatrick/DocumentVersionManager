namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public record ProcessFlowGroupGetRequestByGuidDTO(Guid guid);
    public record ProcessFlowGroupGetRequestByIdDTO(String EntityNameId);
    public record ProcessFlowGroupGetRequestDTO(Object JSONValue);
    public record ProcessFlowGroupCreateRequestDTO(string ProcessFlowGroupName, string defaultTestingMode, string description, Guid guidId);
    public record ProcessFlowGroupUpdateRequestDTO(string ProcessFlowGroupName, string defaultTestingMode, string description, Guid guidId);
    public record ProcessFlowGroupDeleteRequestDTO(Guid guid);


    //public record ProcessFlowGroupGetRequestByIdDTO(string ProcessFlowGroupName); //EntityNameId
    //public record ProcessFlowGroupGetRequestDTO(object Value);//JSONValue
    //public record ProcessFlowGroupCreateRequestDTO(string ProcessFlowGroupName, string testingMode, string description, Guid guidId);
    //public record ProcessFlowGroupUpdateRequestDTO(string ProcessFlowGroupName, string testingMode, string description, Guid guidId);

}