using DocumentVersionManager.DomainBase;
namespace DocumentVersionManager.Domain.Entities
{
    public partial class ModelVersionGroup  : BaseEntity
    {
        private ModelVersionGroup(){}
        public string ModelVersionGroupName    { get; init; }  = string.Empty; 
        public string DefaultTestingMode    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        private  List <ModelVersion> _ModelVersions { get;  set;}  = new List<ModelVersion>();
        public  IReadOnlyCollection<ModelVersion> ModelVersions => _ModelVersions;
        public Guid GuidId    { get; init; } 
        
        public static ModelVersionGroup Create(string  modelVersionGroupName, string  defaultTestingMode, string  description, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ModelVersionGroup Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ModelVersionGroupName = modelVersionGroupName ,
            DefaultTestingMode = defaultTestingMode ,
            Description = description ,
            GuidId = guidId ,
        };
    }
    }
}