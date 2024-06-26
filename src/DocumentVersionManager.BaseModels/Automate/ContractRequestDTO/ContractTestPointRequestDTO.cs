namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public  record TestPointGetRequestByGuidDTO(Guid guid);
    public  record TestPointGetRequestByIdDTO(String EntityNameId);
    public  record TestPointGetRequestDTO(Object EntityNameId);
    public  record TestPointCreateRequestDTO(Int32  modelVersionId, string  modelName, Int32  order, Int32  capacityTestPoint, Guid  guidId );
    public  record TestPointUpdateRequestDTO(Int32  modelVersionId, string  modelName, Int32  order, Int32  capacityTestPoint, Guid  guidId);
    public  record TestPointDeleteRequestDTO(Guid guid);
}