namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public record TestingModeGroupGetRequestByGuidDTO(Guid guid);
    public record TestingModeGroupGetRequestByIdDTO(String EntityNameId);
    public record TestingModeGroupGetRequestDTO(Object JSONValue);
    public record TestingModeGroupCreateRequestDTO(string testingModeGroupName, string defaultTestingMode, string description, Guid guidId);
    public record TestingModeGroupUpdateRequestDTO(string testingModeGroupName, string defaultTestingMode, string description, Guid guidId);
    public record TestingModeGroupDeleteRequestDTO(Guid guid);


    //public record TestingModeGroupGetRequestByIdDTO(string TestingModeGroupName); //EntityNameId
    //public record TestingModeGroupGetRequestDTO(object Value);//JSONValue
    //public record TestingModeGroupCreateRequestDTO(string TestingModeGroupName, string testingMode, string description, Guid guidId);
    //public record TestingModeGroupUpdateRequestDTO(string TestingModeGroupName, string testingMode, string description, Guid guidId);

}