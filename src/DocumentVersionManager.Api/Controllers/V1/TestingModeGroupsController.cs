using DocumentVersionManager.Api.Extentions;
using DocumentVersionManager.Application.CQRS;
using DocumentVersionManager.Api.Extensions;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using Asp.Versioning;
namespace DocumentVersionManager.Api.Controllers.v1
{
    [ApiVersion(1)]
    public class ProcessFlowGroupsController : TheBaseController<ProcessFlowGroupsController>
    {

        public ProcessFlowGroupsController(ILogger<ProcessFlowGroupsController> logger, ISender sender) : base(logger, sender) { }

        [ProducesResponseType(typeof(IEnumerable<ProcessFlowGroupResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Get, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllProcessFlowGroupQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ProcessFlowGroupResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.GetById, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid) ?
                (_sender.Send(new GetProcessFlowGroupByGuidQuery(new ProcessFlowGroupGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetProcessFlowGroupByIdQuery(new ProcessFlowGroupGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.GetByJSONBody, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ProcessFlowGroupGetRequestDTO request, CancellationToken cancellationToken)
                => (_sender.Send(new GetProcessFlowGroupQuery(request), cancellationToken)).ToEitherActionResult();

        [HttpPost(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Create, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Create)]
        public Task<IActionResult> Create(ProcessFlowGroupCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateProcessFlowGroupCommand(request), cancellationToken)).ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Create}", request);

        [HttpPut(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Update, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Update)]
        public Task<IActionResult> Update(ProcessFlowGroupUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateProcessFlowGroupCommand(request), cancellationToken)).ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Create}", request);


        [HttpDelete(template: DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Delete, Name = DocumentVersionManagerAPIEndPoints.ProcessFlowGroup.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            => _sender.Send(new DeleteProcessFlowGroupCommand(new ProcessFlowGroupDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}