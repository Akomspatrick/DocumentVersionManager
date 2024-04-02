using DocumentVersionManager.Contracts.RequestDTO.V1.auto;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Sdk
{
    public interface IDocumentVersionApi
    {


        // [ProducesResponseType(typeof(IEnumerable<ModelResponseDTO>), StatusCodes.Status200OK)]
        //[HttpGet(template: DocumentVersionManagerAPIEndPoints.Model.Get, Name = DocumentVersionManagerAPIEndPoints.Model.Get)]
        [ProducesResponseType(typeof(IEnumerable<ModelResponseDTO>), StatusCodes.Status200OK)]
        [Get("/api/v1/Models")]
        Task<IActionResult> Get(CancellationToken cToken);

       
        [Post("/api/v1/TestingModeGroups")]
        Task<IActionResult> PostAll([Body]TestingModeGroupCreateRequestDTO request);

    }
}
