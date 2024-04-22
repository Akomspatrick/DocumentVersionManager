using DocumentVersionManager.Api.Extensions;
using DocumentVersionManager.Application.CQRS;
using Asp.Versioning;
using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using MediatR;
using DocumentVersionManager.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
namespace DocumentVersionManager.Api.Controllers.V1
{
     [ApiVersion(1)]
    public  class ShellMaterialsController  : TheBaseController<ShellMaterialsController>
    {

        public ShellMaterialsController(ILogger<ShellMaterialsController> logger, ISender sender) : base(logger, sender){}

        [ProducesResponseType(typeof(IEnumerable<ShellMaterialResponseDTO>), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.Get, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.Get)]
        public Task<IActionResult> Get(CancellationToken cToken) => _sender.Send(new GetAllShellMaterialQuery(), cToken).ToActionResult();

        [ProducesResponseType(typeof(ShellMaterialResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.GetById, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.GetById)]
        public Task<IActionResult> GetById([FromRoute] string NameOrGuid, CancellationToken cancellationToken)
        {
            return Guid.TryParse(NameOrGuid, out Guid guid)  ?
                (_sender.Send(new GetShellMaterialByGuidQuery(new ShellMaterialGetRequestByGuidDTO(guid)), cancellationToken)).ToEitherActionResult()
                :
                (_sender.Send(new GetShellMaterialByIdQuery(new ShellMaterialGetRequestByIdDTO(NameOrGuid)), cancellationToken)).ToEitherActionResult();
        }

        [ProducesResponseType(typeof(ShellMaterialResponseDTO), StatusCodes.Status200OK)]
        [HttpGet(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.GetByJSONBody, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.GetByJSONBody)]
        public Task<IActionResult> GetByJSONBody([FromBody] ShellMaterialGetRequestDTO request, CancellationToken cancellationToken)
                => ( _sender.Send(new GetShellMaterialQuery(request), cancellationToken)) .ToEitherActionResult();

        [HttpPost(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.Create, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.Create)]
        public Task<IActionResult> Create(ShellMaterialCreateRequestDTO request, CancellationToken cancellationToken)
             => (_sender.Send(new CreateShellMaterialCommand(request), cancellationToken)).ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ShellMaterial.Create}", request);

        [HttpPut(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.Update, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.Update)]
        public Task<IActionResult> Update(ShellMaterialUpdateRequestDTO request, CancellationToken cancellationToken)
            => (_sender.Send(new UpdateShellMaterialCommand(request), cancellationToken)) .ToActionResultCreated($"{DocumentVersionManagerAPIEndPoints.ShellMaterial.Create}", request);


        [HttpDelete(template: DocumentVersionManagerAPIEndPoints.ShellMaterial.Delete, Name = DocumentVersionManagerAPIEndPoints.ShellMaterial.Delete)]
        public Task<IActionResult> Delete([FromRoute] Guid request, CancellationToken cancellationToken)
            =>_sender.Send(new DeleteShellMaterialCommand(new ShellMaterialDeleteRequestDTO(request)), cancellationToken).ToActionResult();

    }
}