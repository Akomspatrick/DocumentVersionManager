using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/Weather")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private IHostingEnvironment _hostingEnvironment;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        ////}
        //[HttpPost(Name = "GetWeatherForecastqqq")]
        //public IActionResult GenerateBarcode(string text)
        //{

        //    //var writer = new ZXing.Windows.Compatibility.BarcodeWriter() { Format = BarcodeFormat.QR_CODE };


        //    ZXing.Windows.Compatibility.BarcodeWriter barcodeWriter = new ZXing.Windows.Compatibility.BarcodeWriter
        //    {
        //        Format = BarcodeFormat.CODE_128, // Specify the barcode format you want to generate
        //        Options = new EncodingOptions
        //        {
        //            Height = 200, // Specify the height of the barcode image
        //            Width = 400 ,
        //            // Specify the width of the barcode image,
        //        }
        //    };

        //    Bitmap barcodeBitmap = barcodeWriter.Write(text); // Generate the barcode image

        //    MemoryStream stream = new MemoryStream();
        //    barcodeBitmap.Save(stream, ImageFormat.Png); // Save the barcode image to a stream

        //    return File(stream.ToArray(), "image/png"); // Return the barcode image as a file
        //}



        //}

        //[HttpGet(Name = "GetWeatherForecastqqq")]

        //public IActionResult PrintLabel(string productId)
        //{

        //    var value = Encrypt.EncryptDecrypt(productId, 10);
        //    var value2 = Encrypt.EncryptDecrypt(value, 10);
        //    string base64String = GetBarCodeIStream(productId);
        //    var path = Path.Combine(_hostingEnvironment.ContentRootPath, "Reports", "Report1.rdlc");
        //    Random random = new Random();
        //    string imagetype = "pdf";
        //    var ImageResult = new ImageResult(imagetype).Create();
        //    string filename = $"{productId}BarCodelabel_{random.Next(1, 1000000).ToString()}{imagetype}";
        //    var imagesPath = Path.Combine(_hostingEnvironment.ContentRootPath, "BarcodeLabelImages", filename);

        //    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
        //    {
        //        LocalReport locareport = new();
        //        locareport.LoadReportDefinition(stream);
        //        locareport.EnableExternalImages = true;

        //        ReportParameterCollection reportParameters = new()
        //        {
        //            new ReportParameter("ProductId", productId),
        //            new ReportParameter("ModelId", "ML002"),
        //            new ReportParameter("BarCodeImg", base64String, true)
        //        };
        //        locareport.SetParameters(reportParameters);

        //        var result = locareport.Render("PDF");

        //        return File(result, "application/pdf", "Thefile");

        //    }


        //}

        [HttpGet(Name = "GetWeatherForecastqqq")]

        public IActionResult PrintLabelAsFile(string productId)
        {

            var value = Encrypt.EncryptDecrypt(productId, 10);
            var value2 = Encrypt.EncryptDecrypt(value, 10);
            var barcodeBitmap = CreateQrCode(productId);
            //Bitmap barcodeBitmap = barcodeWriter.Write(text); // Generate the barcode image

            MemoryStream stream = new MemoryStream();
            barcodeBitmap.Save(stream, ImageFormat.Png); // Save the barcode image to a stream

            return File(stream.ToArray(), "image/png"); // Return the barcode image as a file

           

            }


        
        //[HttpPost(Name = "GetWeatherForecastqqqsss")]
        //public IActionResult PrintLabel_itisHttpGet(string productId)
        //{

        //    var value = Encrypt.EncryptDecrypt(productId, 10);
        //    var value2 = Encrypt.EncryptDecrypt(value, 10);
        //    string base64String = GetBarCodeIStream(productId);
        //    var path = Path.Combine(_hostingEnvironment.ContentRootPath, "Reports", "Report1.rdlc");
        //    Random random = new Random();
        //    string imagetype = "png";
        //    var ImageResult = new ImageResult(imagetype).Create();
        //    string filename = $"{productId}BarCodelabel_{random.Next(1, 1000000).ToString()}{ImageResult.Extension}";
        //    var imagesPath = Path.Combine(_hostingEnvironment.ContentRootPath, "BarcodeLabelImages", filename);

        //    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
        //    {
        //        LocalReport locareport = new();
        //        locareport.LoadReportDefinition(stream);
        //        locareport.EnableExternalImages = true;

        //        ReportParameterCollection reportParameters = new()
        //        {
        //            new ReportParameter("ProductId", productId),
        //            new ReportParameter("ModelId", "ML002"),
        //            new ReportParameter("BarCodeImg", base64String, true)
        //        };
        //        locareport.SetParameters(reportParameters);

        //        var result = locareport.Render("IMAGE");

        //        using (Image image = Image.FromStream(new MemoryStream(result)))
        //        {
        //            image.Save(imagesPath, ImageResult.TheImageFormat);  // Or Png
        //        }
        //        return PhysicalFile(imagesPath, ImageResult.ImageType, filename);

        //        //* return File(result, "application/pdf", "PrintOut.pdf");
        //        //string format = "PDF"; //Desired format goes here (PDF, Excel, or Image)
        //        //•	"IMAGE"
        //        //•	"WORD"/
        //        //•	"EXCEL"
        //        //•	"CSV"
        //        //•	"XML"
        //        //•	"HTML4.0"
        //        //•	"HTML3.2"
        //        //•	"MHTML" *//* }
        //        // return File(result, "application/pdf", "PrintOut.pdf");
        //    }


        //}


        private static string GetBarCodeIStreamBarcode(string text)
        {
            ZXing.Windows.Compatibility.BarcodeWriter barcodeWriter = new ZXing.Windows.Compatibility.BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128, // Specify the barcode format you want to generate
                Options = new EncodingOptions
                {
                    Height = 40, // Specify the height of the barcode image
                    Width = 300,
                    GS1Format = true,
                    Margin = 0,
                    NoPadding = true,
                    PureBarcode = true,




                    // Specify the width of the barcode image,
                }
            };


            ZXing.QrCode.QRCodeWriter qrCodeWriter = new ZXing.QrCode.QRCodeWriter();




            Bitmap barcodeBitmap = barcodeWriter.Write(text); // Generate the barcode image

            MemoryStream stream = new MemoryStream();
            barcodeBitmap.Save(stream, ImageFormat.Png); // Save the barcode image to a stream

            // return File(stream.ToArray(), "image/png"); // Return the barcode image as a file
            var byteArray = stream.ToArray();
            // return byteArray;
            return Convert.ToBase64String(byteArray);

        }

        private static string GetBarCodeIStream(string text)
        {

            var barcodeBitmap = CreateQrCode(text);
            //Bitmap barcodeBitmap = barcodeWriter.Write(text); // Generate the barcode image

            MemoryStream stream = new MemoryStream();
            barcodeBitmap.Save(stream, ImageFormat.Png); // Save the barcode image to a stream

            //return File(stream.ToArray(), "image/png"); // Return the barcode image as a file
            var byteArray = stream.ToArray();
            // return byteArray;
            return Convert.ToBase64String(byteArray);

        }

        private static  Bitmap CreateQrCode(string data)
        {
            //specify desired options
            QrCodeEncodingOptions options = new QrCodeEncodingOptions()
            {
                CharacterSet = "UTF-8",
                DisableECI = true,
                Width = 250,
                Height = 250
            };

            //create new instance and set properties
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.QR_CODE,
                Options = options
            };

            //create QR code and return Bitmap
            return writer.Write(data);
        }

        private string GetTextFromQrCode(byte[] qrcodeBytes)
        {
            //specify desired options
            DecodingOptions options = new DecodingOptions()
            {
                CharacterSet = "UTF-8"
            };

            //create new instance and set properties
            BarcodeReader reader = new BarcodeReader() { Options = options };

            using (MemoryStream ms = new MemoryStream(qrcodeBytes))
            {
                using (Bitmap bmp = (Bitmap)Bitmap.FromStream(ms))
                {
                    //decode QR code
                    Result r = reader.Decode(bmp);

                    //return QR code text
                    return r.Text;
                }
            }
        }

        private string GetTextFromQrCode(string filename)
        {
            //specify desired options
            DecodingOptions options = new DecodingOptions()
            {
                CharacterSet = "UTF-8"
            };

            //create new instance and set properties
            BarcodeReader reader = new BarcodeReader() { Options = options };

            //read image and convert to Bitmap
            using (Bitmap bmp = (Bitmap)Bitmap.FromFile(filename))
            {
                //decode QR code
                Result r = reader.Decode(bmp);

                //return QR code text
                return r.Text;
            }
        }

        private void SaveQrCode(string data, string filename, System.Drawing.Imaging.ImageFormat imgFormat)
        {
            //create QR code and save to file
            using (Bitmap bmp = CreateQrCode(data))
            {
                bmp.Save(filename, imgFormat);
            }
        }
    }
}
