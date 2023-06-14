using Microsoft.AspNetCore.Mvc.RazorPages;
using QrCodeRenderer.Models;
using System.ComponentModel.DataAnnotations;

namespace QrCodeRenderer.Pages
{
    public class GenerateQrCodeModel : PageModel
    {
        [Required(ErrorMessage = Criteria.GenerateQrCode.ContentQrCodeMessage)]
        public string ContentQrCode { get; set; } = null!;

        public string ContentQrCode_InputPlaceholder { get => Criteria.GenerateQrCode.ContentQrCodeMessage; }

        public void OnGet()
        {
            ;
        }
    }
}
