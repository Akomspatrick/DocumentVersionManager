﻿using Microsoft.Extensions.Logging;

using DocumentVersionManager.Application.CQRS.ModelType.Commands;
using DocumentVersionManager.Application.CQRS.ModelType.Handlers;
using DocumentVersionManager.Domain.Errors;
using DocumentVersionManager.Domain.Interfaces;
using FluentAssertions;
using LanguageExt;
using Microsoft.Extensions.Logging;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentVersionManager.Contracts.RequestDTO.V1;

namespace DocumentVersionManager.Application.Tests.CQRS.ModelType
{
    public class CreateModelTypeCommandTests

    {
        private static readonly ModelTypeCreateRequestDTO modelTypeCreateDTO = new(Guid.NewGuid(), "ML101", "111");
        private static readonly CreateModelTypeCommand createModelTypeCommand = new(CreateModelTypeDTO: modelTypeCreateDTO);
        private readonly CreateModelTypeCommandHandler createModelTypeCommandHandler;
        private readonly IUnitOfWork _unitOfWorkMock;
        private readonly IModelTypeRepository _modelTypeRepositoryMock;
        //private readonly ILogger<CreateModelTypeCommandHandler> _loggerMock;
        private readonly ILogger<CreateModelTypeCommandHandler> _loggerMock;
        public CreateModelTypeCommandTests()
        {
            _unitOfWorkMock = Substitute.For<IUnitOfWork>();
            _loggerMock = Substitute.For<ILogger<CreateModelTypeCommandHandler>>();
            _modelTypeRepositoryMock = Substitute.For<IModelTypeRepository>();
            createModelTypeCommandHandler = new CreateModelTypeCommandHandler(_unitOfWorkMock, _loggerMock, _modelTypeRepositoryMock);
        }

        [Fact]
        public async Task CreateModelTypeCommandHandler_ShouldReturnValidRight_WhenNewModelTypeIsAdded()
        {
            //Arrange
            _modelTypeRepositoryMock.AddAsync(Arg.Any<Domain.Entities.ModelType>(), Arg.Any<CancellationToken>()).Returns(1);
            //Act
            var result = await createModelTypeCommandHandler.Handle(createModelTypeCommand, CancellationToken.None);
            //Assert

            result.IsRight.Should().BeTrue();
            result.Match(
                                        Right: r => r.Should().NotBe(Arg.Any<Guid>()),
                                         Left: l => l.Should().BeEquivalentTo(GeneralFailures.ProblemAddingEntityIntoDbContext("2a7c336a-163c-487d-88ca-c41cc129f118")));//INTERESTED ONLY IN LEFT SIDE

        }
        // implement below for exception handling
        public async Task CreateModelTypeCommandHandler_ShouldThrowAggregateException_WhenNewModelTypeIsAdded()
        {
            //Arrange
            _modelTypeRepositoryMock.AddAsync(Arg.Any<Domain.Entities.ModelType>(), Arg.Any<CancellationToken>()).Returns(1);
            //Act
            var result = await createModelTypeCommandHandler.Handle(createModelTypeCommand, CancellationToken.None);
            //Assert

            result.IsRight.Should().BeTrue();

        }
        [Fact(Skip = "Use integration testing here , else there will be ambiguos arg exception")]
        public async Task CreateModelTypeCommandHandler_ShouldReturnFailure()
        {
            //Arrange
            _modelTypeRepositoryMock.AddAsync(Arg.Any<Domain.Entities.ModelType>(), Arg.Any<CancellationToken>()).Returns(GeneralFailures.ProblemAddingEntityIntoDbContext("2a7c336a-163c-487d-88ca-c41cc129f118"));
            //Act
            var result = await createModelTypeCommandHandler.Handle(createModelTypeCommand, CancellationToken.None);
            //Assert
            result.IsLeft.Should().BeTrue();
            result.Match(
                         Right: r => r.Should().Be(Arg.Any<Guid>()),
                         Left: l => l.Should().BeEquivalentTo(GeneralFailures.ProblemAddingEntityIntoDbContext("2a7c336a-163c-487d-88ca-c41cc129f118")));//INTERESTED ONLY IN LEFT SIDE

        }
        [Fact(Skip = "I have removed logging  from this handler so test will fail for now, but its a good sample for testing logging")]
        public async Task LogInformationShoulBeCalledWhenmethodIsInvoked()
        {
            //Arrange
            //  _unitOfWorkMock.ModelTypesRepository.AddAsync(Arg.Any<Domain.Entities.ModelTypes>(), Arg.Any<CancellationToken>()).Returns(GeneralFailure.ProblemAddingEntityIntoDbContext);
            //Act
            var _ = await createModelTypeCommandHandler.Handle(createModelTypeCommand, CancellationToken.None);
            //Assert
            _loggerMock.Received(1).LogInformation(Arg.Any<string>());
        }

    }
}