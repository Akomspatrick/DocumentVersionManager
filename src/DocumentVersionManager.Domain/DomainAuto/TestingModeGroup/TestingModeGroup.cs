using DocumentVersionManager.DomainBase;
namespace DocumentVersionManager.Domain.Entities
{
    public partial class ProcessFlowGroup  : BaseEntity
    {
        private ProcessFlowGroup(){}
        public string ProcessFlowGroupName    { get; init; }  = string.Empty; 
        public string DefaultTestingMode    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        private  List <ModelVersion> _ModelVersions { get;  set;}  = new List<ModelVersion>();
        public  IReadOnlyCollection<ModelVersion> ModelVersions => _ModelVersions;
        // public Guid GuidId    { get; init; } 
        
        public static ProcessFlowGroup Create(string  ProcessFlowGroupName, string  defaultTestingMode, string  description, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProcessFlowGroup Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProcessFlowGroupName = ProcessFlowGroupName ,
            DefaultTestingMode = defaultTestingMode ,
            Description = description ,
            GuidId = guidId ,
        };
    }
    }
}