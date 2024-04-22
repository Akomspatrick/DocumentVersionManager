namespace DocumentVersionManager.Contracts.RequestDTO.V1
{
    public record ModelGetRequestByGuidDTO(Guid guid);
    public record ModelGetRequestByIdDTO(string EntityNameId);
    public record ModelGetRequestDTO(string ModelName);
    //public record ModelCreateRequestDTO(Guid GuidId, string ModelName, string ModelTypesName);
    //public record ModelUpdateRequestDTO(Guid ModelId, string ModelName, string ModelTypesName);
    public record ModelCreateRequestDTO(string ModelName, string ModelTypesName, Guid GuidId);
    public record ModelUpdateRequestDTO(string ModelName, string ModelTypesName, Guid GuidId);
    public record ModelDeleteRequestDTO(Guid guid);

    //public record ModelRequestDTO(string ModelId);

    //public record ModelCreateDTO(string ModelId, string modelTypesId, string ModelName);
    //public record ModelUpdateDTO(string ModelId, string modelTypesId, string ModelName);
    //public record ModelDeleteDTO(string ModelId);
    ////public record ModelDTOByGuidId(Guid ModelId);
    ////public record ModelRequestDTO(string ModelName);
    ////public record ModelCreateDTO(Guid ModelId, string ModelName, string ModelTypesName);
    ////public record ModelUpdateDTO(Guid ModelId, string ModelName, string ModelTypesName);
    ////public record ModelDeleteDTO(Guid ModelId);
    ///    public  record ModelGetRequestByGuidDTO(Guid guid);
    //public record ModelGetRequestByIdDTO(String EntityNameId);
    //public record ModelGetRequestDTO(Object JSONValue);

    //public record ModelDeleteRequestDTO(Guid guid);
}


