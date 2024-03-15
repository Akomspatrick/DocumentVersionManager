namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ModelTypeGetRequestByGuidDTO(Guid guid);
    public  record ModelTypeGetRequestByIdDTO(String ObjectNameId);
    public  record ModelTypeGetRequestDTO(Object Value);
    public  record ModelTypeCreateRequestDTO(string  modelTypeName, Guid  guidId );
    public  record ModelTypeUpdateRequestDTO(string  modelTypeName, Guid  guidId);
    public  record ModelTypeDeleteRequestDTO(Guid guid);
}