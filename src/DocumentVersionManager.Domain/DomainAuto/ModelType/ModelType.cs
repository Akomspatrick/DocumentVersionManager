using DocumentVersionManager.DomainBase;
namespace DocumentVersionManager.Domain.Entities
{
    public partial class ModelType  : BaseEntity
    {
        private ModelType(){}
        public string ModelTypeName    { get; init; }  = string.Empty; 
        public string ProcessFlowGroupName    { get; init; }  = string.Empty; 
        private  List <Model> _Models { get;  set;}  = new List<Model>();
        public  IReadOnlyCollection<Model> Models => _Models;
        public ProcessFlowGroup ProcessFlowGroup    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static ModelType Create(string  modelTypeName, string  processFlowGroupName, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ModelType Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ModelTypeName = modelTypeName ,
            ProcessFlowGroupName = processFlowGroupName ,
            GuidId = guidId ,
        };
    }
    }
}