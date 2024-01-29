namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ModelVersionGroupGetRequestByGuidDTO(Guid guid);
    public  record ModelVersionGroupGetRequestByIdDTO(Object Value);
    public  record ModelVersionGroupGetRequestDTO(Object Value);
    public  record ModelVersionGroupCreateRequestDTO(string  modelVersionGroupName, string  defaultTestingMode, string  description, Guid  guidId );
    public  record ModelVersionGroupUpdateRequestDTO(string  modelVersionGroupName, string  defaultTestingMode, string  description, Guid  guidId);
    public  record ModelVersionGroupDeleteRequestDTO(Guid guid);
}