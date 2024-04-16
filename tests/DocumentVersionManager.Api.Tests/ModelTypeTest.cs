using DocumentVersionManager.Application.CQRS.ModelType.Queries;

namespace DocumentVersionManager.Api.Tests
{
    public class ModelTypeTest : BaseIntegrationTests
    {
        public ModelTypeTest(IntegrationTestWebAppFactory factory) : base(factory)
        {
        }
        [Fact]
        public async Task GetModelTypes()
        {
            //Arrange

            //Act
            // var response = await sender.Send(new GetAllModelTypeQuery());
            //Assert

            //Assert.NotNull(response);
            //Assert.NotEmpty(response);
        }
    }
}
