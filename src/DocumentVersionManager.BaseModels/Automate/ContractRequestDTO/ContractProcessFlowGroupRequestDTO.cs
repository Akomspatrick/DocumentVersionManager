namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public  record ProcessFlowGroupGetRequestByGuidDTO(Guid guid);
    public  record ProcessFlowGroupGetRequestByIdDTO(String EntityNameId);
    public  record ProcessFlowGroupGetRequestDTO(Object EntityNameId);
    public  record ProcessFlowGroupCreateRequestDTO(string  processFlowGroupName, string  defaultTestingMode, string  description, Guid  guidId );
    public  record ProcessFlowGroupUpdateRequestDTO(string  processFlowGroupName, string  defaultTestingMode, string  description, Guid  guidId);
    public  record ProcessFlowGroupDeleteRequestDTO(Guid guid);
}