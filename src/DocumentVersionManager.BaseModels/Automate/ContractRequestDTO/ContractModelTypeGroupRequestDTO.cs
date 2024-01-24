namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ModelTypeGroupGetRequestByGuidDTO(Guid guid);
    public  record ModelTypeGroupGetRequestByIdDTO(Object Value);
    public  record ModelTypeGroupGetRequestDTO(Object Value);
    public  record ModelTypeGroupCreateRequestDTO(string  modelTypeGroupName, string  testingMode, string  description, Guid  guidId );
    public  record ModelTypeGroupUpdateRequestDTO(string  modelTypeGroupName, string  testingMode, string  description, Guid  guidId);
    public  record ModelTypeGroupDeleteRequestDTO(Guid guid);
}