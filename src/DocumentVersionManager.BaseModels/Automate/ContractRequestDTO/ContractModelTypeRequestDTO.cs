namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public  record ModelTypeGetRequestByGuidDTO(Guid guid);
    public  record ModelTypeGetRequestByIdDTO(String EntityNameId);
    public  record ModelTypeGetRequestDTO(Object EntityNameId);
    public  record ModelTypeCreateRequestDTO(string  modelTypeName, string  processFlowGroupName, Guid  guidId );
    public  record ModelTypeUpdateRequestDTO(string  modelTypeName, string  processFlowGroupName, Guid  guidId);
    public  record ModelTypeDeleteRequestDTO(Guid guid);
}