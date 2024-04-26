using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
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


        // // [ProducesResponseType(typeof(IEnumerable<ModelResponseDTO>), StatusCodes.Status200OK)]
        // //[HttpGet(template: DocumentVersionManagerAPIEndPoints.Model.Get, Name = DocumentVersionManagerAPIEndPoints.Model.Get)]
        // [ProducesResponseType(typeof(GeneralFailures), StatusCodes.Status400BadRequest)]
        // [ProducesResponseType(typeof(IEnumerable<ModelResponseDTO>), StatusCodes.Status200OK)]
        // [Get("/api/v1/Models")]
        // Task<ApiResponse< IEnumerable<ModelResponseDTO>>> Get(CancellationToken cToken);

        //internal Task< Either<GeneralFailure, ModelTypeResponseDTO?> GetInternal();

        // public async Either<GeneralFailure, ModelTypeResponseDTO> GetInternal();




        // [ProducesResponseType(typeof(GeneralFailures), StatusCodes.Status400BadRequest)]
        // [ProducesResponseType(typeof(ProcessFlowGroupCreateRequestDTO), StatusCodes.Status200OK)]

        // [Post("/api/v1/ProcessFlowGroups")]
        // Task<ProcessFlowGroupCreateRequestDTO> PostAll([Body]ProcessFlowGroupCreateRequestDTO request);
        //[Get("/api/v1/Models")]
        //internal Task<Either<GeneralFailure, ModelTypeResponseDTO>> GetInternal();

        //public async Task<Either<GeneralFailure, ModelTypeResponseDTO>> Get()
        //{
        //    var response = await GetInternal();
        //    return response;
        //}

        [Get("/api/v1/Models")]
        Task<IActionResult> Get(CancellationToken cToken);




        [Post("/api/v1/ProcessFlowGroups")]
        internal Task<Either<GeneralFailure, ProcessFlowGroupCreateRequestDTO>> PostInternal([Body] ProcessFlowGroupCreateRequestDTO request);

        public async Task<Either<GeneralFailure, ProcessFlowGroupCreateRequestDTO>> Post([Body] ProcessFlowGroupCreateRequestDTO request)
        {
            var response = await PostInternal(request);
            return response;
        }


    }
}
