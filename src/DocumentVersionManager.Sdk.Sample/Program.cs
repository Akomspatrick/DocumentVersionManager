

using DocumentVersionManager.Sdk;
using Refit;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using DocumentVersionManager.Contracts.RequestDTO.V1;
using DocumentVersionManager.Domain.Errors;
using LanguageExt;

class Program
{

    static async Task Main(string[] args)
    {



        try
        {
            var documentApi = Refit.RestService.For<IDocumentVersionApi>("https://localhost:7181");
            var response = await documentApi.Get(CancellationToken.None);

            var document = "dddd";
        }
        catch (Exception ex)
        {

            throw;
        }
        //try
        //{
        //    var documentApi = Refit.RestService.For<IDocumentVersionApi>("https://localhost:7181");
        //    var response = await documentApi.Get(CancellationToken.None);
        //    // apiResponse = new ApiResponse();
        //    // var request = new ProcessFlowGroupCreateRequestDTO(testingMode: "string7", ProcessFlowGroupName: "5string789", description: "string", guidId: Guid.NewGuid());

        //    //   Either < GeneralFailure, ProcessFlowGroupCreateRequestDTO > response = await documentApi.Post(request);
        //    var document = "dddd";
        //}
        //catch (Exception ex)
        //{

        //    throw;
        //}


    }
}