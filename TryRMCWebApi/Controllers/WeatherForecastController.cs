using Microsoft.AspNetCore.Mvc;
using RMCLinkNET;

namespace TryRMCWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private RMCLink rmc;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {


            // rmc = RMCLinkNET.RMCLink.CreateEthernetLink(RMCLinkNET.DeviceType.RMC70, "rmc70.deltamotion.com");

            rmc = RMCLinkNET.RMCLink.CreateEthernetLink(RMCLinkNET.DeviceType.RMC70, "rmc70.deltamotion.com");

            Console.WriteLine("Connecting...");
            rmc.Connect();

            try
            {
                // float[] data = new float[1];

                // Console.WriteLine("Reading Axis 0 Actual Position...");
                //  rmc.ReadFFile((int)FileNumber70.fn70StatusAxis0, 8, data, 0, 1);
                //   Console.WriteLine(String.Format("  ActPos: {0:F3}", data[0]));


                float[] data2 = new float[2];
                int axis = 0;
                // Read the Target Position (Fx:53) into data[0].
                rmc.ReadFFile((int)FileNumber70.fn70StatusAxis0 + axis, 53, data2, 0, 1);

                // Read the Actual Position (Fx:8) into data[1].
                rmc.ReadFFile((int)FileNumber70.fn70StatusAxis0 + axis, 8, data2, 1, 1);

                Console.WriteLine("Done");
            }
            catch (ConnectionNotMadeException ex)
            {
                Console.WriteLine("Unable to connect. " + ex.Message);
            }
            finally
            {
                rmc.Disconnect();
            }






            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();




        }
        [HttpPost(Name = "PostPi")]
        public IActionResult Post(string ip)
        {


            rmc = RMCLinkNET.RMCLink.CreateEthernetLink(RMCLinkNET.DeviceType.RMC70, ip);





            try
            {
                Console.WriteLine("Connecting...");
                rmc.Connect();
            }
            catch (ConnectionNotMadeException ex)
            {
                Console.WriteLine("Unable to connect. " + ex.Message);
            }
            finally
            {
                rmc.Disconnect();
            }



            return Ok("Congratulations from " + ip);




        }
    }
}
