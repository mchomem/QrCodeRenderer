using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace QrCodeRenderer.Pages
{
    public class GenerateQrCodeModel : PageModel
    {


        [Required(ErrorMessage = "Type a value to QR Code content!")]
        public string ContentQrCode { get; set; } = null!;

        public void OnGet()
        {
        }
    }
}
