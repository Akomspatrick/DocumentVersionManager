namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record TestPointGetRequestByGuidDTO(Guid guid);
    public  record TestPointGetRequestByIdDTO(String ObjectNameId);
    public  record TestPointGetRequestDTO(Object Value);
    public  record TestPointCreateRequestDTO(Int32  modelVersionId, string  modelName, Int32  capacityTestPoint, Guid  guidId );
    public  record TestPointUpdateRequestDTO(Int32  modelVersionId, string  modelName, Int32  capacityTestPoint, Guid  guidId);
    public  record TestPointDeleteRequestDTO(Guid guid);
}