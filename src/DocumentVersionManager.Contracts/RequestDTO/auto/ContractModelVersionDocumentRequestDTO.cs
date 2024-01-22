namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ModelVersionDocumentGetRequestByGuidDTO(Guid guid);
    public  record ModelVersionDocumentGetRequestByIdDTO(Object Value);
    public  record ModelVersionDocumentGetRequestDTO(Object Value);
    public  record ModelVersionDocumentCreateRequestDTO(Guid GuidId,Object Value );
    public  record ModelVersionDocumentUpdateRequestDTO(Object Value);
    public  record ModelVersionDocumentDeleteRequestDTO(Guid guid);
}