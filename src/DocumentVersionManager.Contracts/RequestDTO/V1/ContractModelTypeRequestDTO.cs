﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Contracts.RequestDTO.V1
{


    public record ModelTypeCreateRequestDTO(Guid GuidId, string ModelTypeName, string ProcessFlowGroupName);


    public record ModelTypeUpdateRequestDTO(Guid ModelTypeId, string ModelTypeName, string ProcessFlowGroupName);
    public record ModelTypeGetRequestByGuidDTO(Guid ModelTypeId);
    public record ModelTypeGetRequestByIdDTO(string EntityNameId);
    public record ModelTypeGetRequestDTO(string JSONValue);
    public record ModelTypeDeleteRequestDTO(Guid guid);



}
