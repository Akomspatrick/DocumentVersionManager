using DocumentVersionManager.Api.Extentions;
using DocumentVersionManager.Application.CQRS;
using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Contracts.ResponseDTO;
using DocumentVersionManager.Api.Extensions;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading;
namespace DocumentVersionManager.Api.Controllers.v1
{
    public  class ModelVersionGroupsController  : TheBaseController<ModelVersionGroupsController>
    {

        public ModelVersionGroupsController(ILogger<ModelVersionGroupsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ModelVersionGroupResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Get, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllModelVersionGroupQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ModelVersionGroupResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.GetById, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetModelVersionGroupByGuidQuery(new ModelVersionGroupGetRequestByGuidDTO(guid)), cancellationToken)).ToActionResult404()
                :
                (_sender.Send(new GetModelVersionGroupByIdQuery(new ModelVersionGroupGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToActionResult404();
        }

        [ProducesResponseType(typeof(ModelTypeResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.GetByJSONBody, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ModelVersionGroupGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetModelVersionGroupQuery(request), cancellationToken)) .ToActionResult404();

        [HttpPost(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Create, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Create)]
        public Task<IActionResult> Create(ModelVersionGroupCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateModelVersionGroupCommand(request), cancellationToken)).ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Create}", request);

        [HttpPut(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Update, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Update)]
        public Task<IActionResult> Update(ModelVersionGroupUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateModelVersionGroupCommand(request), cancellationToken)) .ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Create}", request);


        [HttpDelete(template: DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Delete, Name = DocumentVersionManagerAPIEndPoints.ModelVersionGroup.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteModelVersionGroupCommand(new ModelVersionGroupDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}