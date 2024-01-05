using DocumentVersionManager.DomainBase.Base;
namespace DocumentVersionManager.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class DocumentType  : BaseEntity
    {
        private DocumentType(){}
            public string DocumentTypeName    { get; init; }  = string.Empty; 
        private  List <DocumentDocumentType> _DocumentDocumentTypes { get;  set;}  = new List<DocumentDocumentType>();
        public  IReadOnlyCollection<DocumentDocumentType> DocumentDocumentTypes => _DocumentDocumentTypes;
            public Guid GuidId    { get; init; } 
        
        public static DocumentType Create(string  documentTypeName, Guid  guidId)
        =>new()
        {
            DocumentTypeName = documentTypeName ,
            GuidId = guidId ,
        };
    }
}