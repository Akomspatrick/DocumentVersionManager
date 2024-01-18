using DocumentVersionManager.DomainBase;
namespace DocumentVersionManager.Domain.Entities
{
    public partial class DocumentDocumentType  : BaseEntity
    {
        private DocumentDocumentType(){}
        public string DocumentName    { get; init; }  = string.Empty; 
        public int ModelVersionId    { get; init; } 
        public string ModelName    { get; init; }  = string.Empty; 
        public string DocumentTypeName    { get; init; }  = string.Empty; 
        public Document Document    { get; init; } 
        public DocumentType DocumentType    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static DocumentDocumentType Create(string  documentName, int  modelVersionId, string  modelName, string  documentTypeName, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"DocumentDocumentType Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            DocumentName = documentName ,
            ModelVersionId = modelVersionId ,
            ModelName = modelName ,
            DocumentTypeName = documentTypeName ,
            GuidId = guidId ,
        };
    }
    }
}