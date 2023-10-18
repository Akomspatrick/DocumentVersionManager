﻿using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.Contracts.ResponseDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Application.CQRS.Model.Queries
{
    public record  GetModelsQuery(ApplicationModelRequestDTO modelRequestDTO) : IRequest<Either<GeneralFailures, ApplicationModelResponseDTO>>;
    
}
