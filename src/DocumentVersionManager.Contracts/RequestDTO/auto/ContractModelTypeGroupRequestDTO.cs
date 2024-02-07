namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record TestingModeGroupGetRequestByGuidDTO(Guid guid);
    public  record TestingModeGroupGetRequestByIdDTO(Object Value);
    public  record TestingModeGroupGetRequestDTO(Object Value);
    public  record TestingModeGroupCreateRequestDTO(string  TestingModeGroupName, string  testingMode, string  description, Guid  guidId );
    public  record TestingModeGroupUpdateRequestDTO(string  TestingModeGroupName, string  testingMode, string  description, Guid  guidId);
    public  record TestingModeGroupDeleteRequestDTO(Guid guid);
}