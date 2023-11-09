namespace DocumentVersionManager.Domain.BaseModels.Entities
{
    public  class ModelVersion  : BaseEntity
        {
            public int ModelVersionId    { get; init; } 
            public string VersionDescription    { get; init; }  = string.Empty; 
            public string ModelVersionName    { get; init; }  = string.Empty; 
            public string ModelName    { get; init; }  = string.Empty; 
            public DateTime Timestamp    { get; init; } 
            public string Username    { get; init; }  = string.Empty; 
            public Guid GuidId    { get; init; } 
        }
}