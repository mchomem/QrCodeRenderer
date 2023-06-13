using Microsoft.AspNetCore.Mvc.RazorPages;
using QrCodeRenderer.Services;

namespace QrCodeRenderer.Pages
{
    public class RenderQrCodeModel : PageModel
    {
        private readonly QrCodeService _qrCodeService;

        public RenderQrCodeModel(QrCodeService qrCodeService)
            => _qrCodeService = qrCodeService;

        public string imageSource = string.Empty;

        public void OnPost()
        {
            imageSource = _qrCodeService.BitmapToImageSource(Request.Form["ContentQrCode"]);
        }
    }
}
