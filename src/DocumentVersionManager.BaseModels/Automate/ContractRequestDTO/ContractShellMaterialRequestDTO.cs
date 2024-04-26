namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public  record ShellMaterialGetRequestByGuidDTO(Guid guid);
    public  record ShellMaterialGetRequestByIdDTO(String EntityNameId);
    public  record ShellMaterialGetRequestDTO(Object EntityNameId);
    public  record ShellMaterialCreateRequestDTO(string  shellMaterialName, bool  alloy, Guid  guidId );
    public  record ShellMaterialUpdateRequestDTO(string  shellMaterialName, bool  alloy, Guid  guidId);
    public  record ShellMaterialDeleteRequestDTO(Guid guid);
}