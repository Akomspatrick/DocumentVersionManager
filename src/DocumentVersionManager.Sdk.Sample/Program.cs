

using DocumentVersionManager.Sdk;

class Program
{

    static async Task Main(string[] args)
    {
        try
        {
    Console.WriteLine("Hello World!");
        var documentApi = Refit.RestService.For<IDocumentVersionApi>("https://localhost:7181");
        var response = await documentApi.Get(CancellationToken.None);
        var document = "dddd";
        }
        catch (Exception ex)
        {

            throw ;
        }
    
    }   
}