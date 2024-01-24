namespace DocumentVersionManager.Contracts.RequestDTO
{
    public  record ProductGetRequestByGuidDTO(Guid guid);
    public  record ProductGetRequestByIdDTO(Object Value);
    public  record ProductGetRequestDTO(Object Value);
    public  record ProductCreateRequestDTO(int  productId, int  modelVersionId, string  modelName, int  capacity, DateTime  timestamp, string  stage, string  subStage, string  salesOrderId, int  cableLength, int  inspectionResult, string  defaultTestingMode, string  modelTypeGroupName, string  usedTestingMode, string  thermexPurcharseOrderNo, string  machiningPurcharseOrderNo, string  steelPurcharseOrderNo, int  batcNo, Guid  guidId );
    public  record ProductUpdateRequestDTO(int  productId, int  modelVersionId, string  modelName, int  capacity, DateTime  timestamp, string  stage, string  subStage, string  salesOrderId, int  cableLength, int  inspectionResult, string  defaultTestingMode, string  modelTypeGroupName, string  usedTestingMode, string  thermexPurcharseOrderNo, string  machiningPurcharseOrderNo, string  steelPurcharseOrderNo, int  batcNo, Guid  guidId);
    public  record ProductDeleteRequestDTO(Guid guid);
}