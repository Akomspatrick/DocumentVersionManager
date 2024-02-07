namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record TestingModeGroupGetRequestByGuidDTO(Guid guid);
    public  record TestingModeGroupGetRequestByIdDTO(Object Value);
    public  record TestingModeGroupGetRequestDTO(Object Value);
    public  record TestingModeGroupCreateRequestDTO(string  modelVersionGroupName, string  defaultTestingMode, string  description, Guid  guidId );
    public  record TestingModeGroupUpdateRequestDTO(string  modelVersionGroupName, string  defaultTestingMode, string  description, Guid  guidId);
    public  record TestingModeGroupDeleteRequestDTO(Guid guid);
}