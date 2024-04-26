namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public  record ModelVersionDocumentGetRequestByGuidDTO(Guid guid);
    public  record ModelVersionDocumentGetRequestByIdDTO(String EntityNameId);
    public  record ModelVersionDocumentGetRequestDTO(Object EntityNameId);
    public  record ModelVersionDocumentCreateRequestDTO(Int32  modelVersionId, string  modelName, Int32  modelVersionDocumentId, string  documentDescription, string  stage, string  documentDrive, string  documentPath, Guid  documentGuid, string  documentname, DateTime  timestamp, string  userName, Guid  guidId );
    public  record ModelVersionDocumentUpdateRequestDTO(Int32  modelVersionId, string  modelName, Int32  modelVersionDocumentId, string  documentDescription, string  stage, string  documentDrive, string  documentPath, Guid  documentGuid, string  documentname, DateTime  timestamp, string  userName, Guid  guidId);
    public  record ModelVersionDocumentDeleteRequestDTO(Guid guid);
}