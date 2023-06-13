using QRCoder;
using System.Drawing;
using System.Runtime.Versioning;

namespace QrCodeRenderer.Services
{
    public class QrCodeService
    {
        [SupportedOSPlatform("windows")]
        public Bitmap GenerateImage(string content)
        {
            //var qrCode = new QRCode(qrCodeData); // issue: https://github.com/codebude/QRCoder/issues/361

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            return new Bitmap(new MemoryStream(qrCodeImage));
        }

        [SupportedOSPlatform("windows")]
        public string BitmapToImageSource(string content)
        {
            var bitmap = GenerateImage(content);
            var imageSource = string.Empty;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = memoryStream.ToArray();
                imageSource = $"data:image/png;base64,{Convert.ToBase64String(imageBytes)}";
            }

            return imageSource;
        }
    }
}
