namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ModelGetRequestByGuidDTO(Guid guid);
    public  record ModelGetRequestByIdDTO(Object Value);
    public  record ModelGetRequestDTO(Object Value);
    public  record ModelCreateRequestDTO(string  modelName, string  modelTypeName, Guid  guidId );
    public  record ModelUpdateRequestDTO(string  modelName, string  modelTypeName, Guid  guidId);
    public  record ModelDeleteRequestDTO(Guid guid);
}