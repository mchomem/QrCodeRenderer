using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using QrCodeRenderer.Services;
using System.Runtime.Versioning;

namespace QrCodeRenderer.Pages
{
    public class RenderQrCodeModel : PageModel
    {
        private readonly QrCodeService _qrCodeService;

        public RenderQrCodeModel(QrCodeService qrCodeService)
            => _qrCodeService = qrCodeService;

        public string imageSource = string.Empty;

        [SupportedOSPlatform("windows")]
        public void OnPost()
        {
            StringValues content = Request.Form["ContentQrCode"];

            if(content.Count == 0)
                throw new Exception("Content not informed.");

            imageSource = _qrCodeService.BitmapToImageSource(content);
        }
    }
}
