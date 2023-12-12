﻿using Asp.Versioning;
using DocumentVersionManager.Api.Extentions;
using DocumentVersionManager.Application.Contracts.RequestDTO;
using DocumentVersionManager.Application.CQRS.Model.Commands;
using DocumentVersionManager.Application.CQRS.Model.Queries;
using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Application.CQRS.ModelType.Queries;
using DocumentVersionManager.Contracts.RequestDTO;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocumentVersionManager.Api.Controllers.v1
{

    public class ModelController : TheBaseController<ModelController>
    {
        public ModelController(ILogger<ModelController> logger, ISender sender) : base(logger, sender)
        {
        }



        [HttpGet(template: DocumentVersionManagerAPIEndPoints.Model.Get, Name = DocumentVersionManagerAPIEndPoints.Model.Get)]
        public async Task<IActionResult> Get([FromBody] ModelRequestDTO request, CancellationToken cancellationToken)
        {
            var x = request.EnsureInputIsNotNull("Input Cannot be null");
            return (await _sender.Send(new GetModelsQuery(new ApplicationModelRequestDTO(request.ModelName)), cancellationToken))
            .Match<IActionResult>(Left: errors => new OkObjectResult(errors),
                                Right: result => new OkObjectResult(result));
        }

        [HttpGet(template: DocumentVersionManagerAPIEndPoints.Model.GetAll, Name = DocumentVersionManagerAPIEndPoints.Model.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return (await _sender.Send(new GetAllModelsQuery(), cancellationToken))
            .Match<IActionResult>(Left: errors => new OkObjectResult(errors),
                                Right: result => new OkObjectResult(result));
        }

        [HttpPost(template: DocumentVersionManagerAPIEndPoints.Model.Create, Name = DocumentVersionManagerAPIEndPoints.Model.Create)]
        public async Task<IActionResult> Create(ModelCreateDTO request, CancellationToken cancellationToken)
        {
            var model = new ApplicationModelCreateDTO(request.ModelId, request.ModelName, request.ModelTypesName);

            return model.EnsureInputIsNotEmpty("Input Cannot be Empty")//.EnsureInputIsNotEmpty("Input Cannot be empty")
                .Bind<Either<GeneralFailure, int>>(modelType => CreateModel(model, cancellationToken).Result)
                .Match<IActionResult>(Left: errors => new OkObjectResult(errors),
                      Right: result => result.Match<IActionResult>(
                      Left: errors2 => new OkObjectResult(errors2),
                      Right: result2 => Created($"/{DocumentVersionManagerAPIEndPoints.ModelType.Create}/{model.ModelId}", model)));
        }



        [HttpDelete(template: DocumentVersionManagerAPIEndPoints.Model.Delete, Name = DocumentVersionManagerAPIEndPoints.Model.Delete)]
        public async Task<IActionResult> Get([FromBody] ModelDeleteDTO request, CancellationToken cancellationToken)
        {
            var x = request.EnsureInputIsNotNull("Input Cannot be null");
            return (await _sender.Send(new DeleteModelCommand(new ApplicationModelDeleteDTO(request.ModelId)), cancellationToken))
            .Match<IActionResult>(Left: errors => new OkObjectResult(errors),
                                Right: result => new OkObjectResult(result));
        }

        [HttpPut(template: DocumentVersionManagerAPIEndPoints.Model.Update, Name = DocumentVersionManagerAPIEndPoints.Model.Update)]
        public async Task<IActionResult> Update(ModelUpdateDTO request, CancellationToken cancellationToken)
        {
            var modelType = new ApplicationModelUpdateDTO(request.ModelId, request.ModelName, request.ModelTypesName);

            return modelType.EnsureInputIsNotEmpty("Input Cannot be Empty")//.EnsureInputIsNotEmpty("Input Cannot be empty")
                .Bind<Either<GeneralFailure, int>>(modelType => UpdateModelType(modelType, cancellationToken).Result)
                .Match<IActionResult>(Left: errors => new OkObjectResult(errors),
                      Right: result => result.Match<IActionResult>(
                      Left: errors2 => new OkObjectResult(errors2),
                      Right: result2 => Created($"/{DocumentVersionManagerAPIEndPoints.ModelType.Create}/{modelType.ModelId}", modelType)));
        }

        private async Task<Either<GeneralFailure, int>> UpdateModelType(ApplicationModelUpdateDTO modelType, CancellationToken cancellationToken)
       => await _sender.Send(new UpdateModelCommand(modelType), cancellationToken);










        private async Task<Either<GeneralFailure, int>> CreateModel(ApplicationModelCreateDTO modelType, CancellationToken cancellationToken)
           => await _sender.Send(new CreateModelCommand(modelType), cancellationToken);

    }
}
