﻿using System.Net.Http.Json;
using System.Net;
using FluentAssertions;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using AutoBogus;
using Microsoft.AspNetCore.Http;
using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Contracts.ResponseDTO.V1;
using DocumentVersionManager.Api.Controllers;

namespace DocumentVersionManager.Integration.Tests.ModelsController
{
    public class ModelsControllerTest : BaseIntegrationTests
    {

        //private readonly HttpClient _httpClient1;
        //private readonly HttpClient _httpClient2;
        private readonly string _baseUrl = "http://localhost:5007/api/v1/";
        //private readonly List<Guid> createdGuids = new();

        public ModelsControllerTest(IntegrationTestWebAppFactory factory) : base(factory)
        {
            //_httpClient1 = factory.CreateClient();
            //_httpClient2 = factory.CreateClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
            //  _httpClient.BaseAddress = new Uri($"{_baseUrl}{DocumentVersionManagerAPIEndPoints.APIBase}/");
        }

        [Theory]
        [InlineData("ProcessFlowGroups/", "SECONDMODELNAME")]
        [InlineData("ProcessFlowGroups/", "7808711f-544a-423d-8d99-f00c31e35be5")]
        // [InlineData("Models/", "")]
        public async Task GetModelShouldRetunHttpStatusCode_OK(string path, string item)
        {
            // act
            //            INSERT INTO `TestDocumentVersionManagerDB`.`ProcessFlowGroups`
            //(`ProcessFlowGroupName`,
            //`DefaultTestingMode`,
            //`Description`,
            //`GuidId`)
            //VALUES
            //("1232", "2342", "1223", uuid());

            // Create whaever you are trying to check dont depent on init else thus test will not be repeatable
            // use a faker to create a model
            // use docker also for testing
            var response = await _httpClient.GetAsync(path + item);
            var response2 = await _httpClient.GetAsync(path);
            var response3 = await _httpClient.GetAsync("ProcessFlowGroups/");

            var response4 = await _httpClient.GetAsync("ProcessFlowGroups/");
            var response6 = await _httpClient.GetAsync("/ProcessFlowGroups");
            var response5 = await _httpClient.GetAsync("/ProcessFlowGroups/");
            var response7 = await _httpClient.GetAsync("/ProcessFlowGroups/Get");
            var response8 = await _httpClient.GetAsync("/api/ProcessFlowGroups/Get/");
            //assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]

        public async Task GetModelByJSONBodyShouldRetunHttpStatusCode_OK()
        {
            // arrange 

            var json = JsonConvert.SerializeObject(new ModelGetRequestDTO("SECONDMODELNAME"));

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:5007/api/Models/JsonBody"),

                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            // act
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GetModelByJSONBodyShouldRetunShouldASingleModelType()
        {
            // arrange 
            ModelGetRequestDTO modelGetRequestDTO = new ModelGetRequestDTO("SECONDMODELNAME");
            var json = JsonConvert.SerializeObject(modelGetRequestDTO);

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:5007/api/Models/JsonBody"),

                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            // act
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            //Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var result = await response.Content.ReadFromJsonAsync<ModelResponseDTO>();
            result.Should().BeAssignableTo<ModelResponseDTO>();
            result.ModelName.Should().Be(modelGetRequestDTO.ModelName);
        }


        [Theory]
        [InlineData("Models/", "SECONDMODELNAME")]
        [InlineData("Models/", "7808711f-544a-423d-8d99-f00c31e35be5")]
        [InlineData("Models/", "")]
        public async Task GetResultShoulNotBeNullModelTypeShouldASingleModelType(string path, string item)
        {
            // act
            var response = await _httpClient.GetAsync(path + item);
            //assert
            Assert.NotNull(response);
        }


        [Theory]
        [InlineData("Models/", "SECONDMODELNAME")]
        public async Task GetByIdModelShouldASingleModelType(string path, string item)
        {
            // act
            var response = await _httpClient.GetAsync(path + item);

            var result = await response.Content.ReadFromJsonAsync<ModelResponseDTO>();

            //assert
            result.Should().BeAssignableTo<ModelResponseDTO>();
            result.ModelName.Should().Be(item);
        }

        [Theory]
        [InlineData("Models/", "7808711f-544a-423d-8d99-f00c31e35be5")]
        public async Task GetByIdModeShouldASingleModelType_GUID(string path, string item)
        {

            // act
            var response = await _httpClient.GetAsync(path + item);
            var result = await response.Content.ReadFromJsonAsync<ModelResponseDTO>();

            //assert
            result.Should().BeAssignableTo<ModelResponseDTO>();
            result.GuidId.Should().Be(Guid.Parse(item));
        }

        [Theory]
        [InlineData("Models/", "")]
        public async Task GetModelShouldAListOfModelTypes(string path, string item)
        {
            // act
            var response = await _httpClient.GetAsync(path + item);
            response.StatusCode.Should().Be(HttpStatusCode.OK);

            var result = await response.Content.ReadFromJsonAsync<List<ModelResponseDTO>>();
            result.Capacity.Should().BeGreaterThan(1);
        }

        [Theory]
        [InlineData("Models/", "SECONDMODELNAMEXX")]
        [InlineData("Models/", "9908711f-544a-423d-8d99-f00c31e35be5")]

        public async Task GetASingleModelShouldRetunHttpStatusCode_NotFound_IfItemDoesNotExit(string path, string item)
        {
            // act
            var response = await _httpClient.GetAsync(path + item);
            Assert.NotNull(response);
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
            //var text = await response.Content.ReadAsStringAsync();
            //var problem = await response.Content.ReadFromJsonAsync<ProblemDetails>();
        }

        [Theory]

        [InlineData("Modelxxx/", "SECONDMODELNAME")]
        public async Task ShouldReturnNotFoundIfPathIsWrong(string path, string item)
        {
            // act
            var response = await _httpClient.GetAsync(path + item);

            //assert
            Assert.NotNull(response);
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }


        [Theory]
        [InlineData("Models")]

        public async Task PostShouldReturnCreated_WhenModelNameIsUniqueAndModelTypeExistAsForeignkey(string path)
        {
            //araange
            var faker = new AutoFaker<ModelCreateRequestDTO>()
                .RuleFor(x => x.GuidId, f => Guid.NewGuid())
                .RuleFor(x => x.ModelName, f => f.Commerce.ProductName())
               .RuleFor(x => x.ModelTypesName, f => "FIRSTMODELTYPE");// Added an existing ModelType
            ModelCreateRequestDTO modelGetRequestDTO = faker.Generate();

            //act
            var response = await _httpClient.PostAsJsonAsync(path, modelGetRequestDTO);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);

        }
        [Theory]
        [InlineData("Models")]
        public async Task PostShouldReturnBadRequest_When_DuplicateModelExistForSameModelType(string path)
        {
            //araange
            var faker = new AutoFaker<ModelCreateRequestDTO>()
                .RuleFor(x => x.GuidId, f => Guid.NewGuid())
                .RuleFor(x => x.ModelName, f => f.Commerce.ProductName())
               .RuleFor(x => x.ModelTypesName, f => "FIRSTMODELTYPE");// Added an existing ModelType
            ModelCreateRequestDTO modelGetRequestDTO = faker.Generate();

            //act
            var response1 = await _httpClient.PostAsJsonAsync(path, modelGetRequestDTO);
            var response = await _httpClient.PostAsJsonAsync(path, modelGetRequestDTO);
            //assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

        }
        [Theory]
        [InlineData("Models")]

        public async Task PostShouldReturn_BadRequest_WhenModelNameIsUniqueAndModelTypeDoesNotExistAsForeignKey(string path)
        {
            //araange
            var faker = new AutoFaker<ModelCreateRequestDTO>()
                .RuleFor(x => x.GuidId, f => Guid.NewGuid())
                .RuleFor(x => x.ModelName, f => f.Commerce.ProductName())
               .RuleFor(x => x.ModelTypesName, f => f.Commerce.ProductName());
            ModelCreateRequestDTO modelGetRequestDTO = faker.Generate();

            //act
            var response = await _httpClient.PostAsJsonAsync(path, modelGetRequestDTO);

            //assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);

        }




        [Theory]
        [InlineData("Model")]

        public async Task PostShouldCreateModelObject_WithCorrectHeaderLocation_WhenSuccessful(string path)
        {
            //arrange
            //araange
            var faker = new AutoFaker<ModelCreateRequestDTO>()
                .RuleFor(x => x.GuidId, f => Guid.NewGuid())
                .RuleFor(x => x.ModelName, f => f.Commerce.ProductName())
               .RuleFor(x => x.ModelTypesName, f => "FIRSTMODELTYPE");// Added an existing ModelType
            ModelCreateRequestDTO modelGetRequestDTO = faker.Generate();
            var ExpetedHeaderLocation = $"{path}/{modelGetRequestDTO.GuidId}";

            //act
            var response = await _httpClient.PostAsJsonAsync(path, modelGetRequestDTO);

            //assert

            response.Headers.Location?.OriginalString.Should().EndWith(ExpetedHeaderLocation);

        }

        public Task InitializeAsync() => Task.CompletedTask;

        public Task DisposeAsync() => Task.CompletedTask;
        //{
        //    throw new NotImplementedException();
        //}
    }
}
