using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace PdfShareSimple.Pages;

public class IndexModel : PageModel
{
    public string[] PdfFiles { get; set; } = Array.Empty<string>();

    public void OnGet()
    {
        var pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "pdf");
        if (Directory.Exists(pdfPath))
        {
            PdfFiles = Directory.GetFiles(pdfPath, "*.pdf")
                               .Select(f => "/pdf/" + Path.GetFileName(f))
                               .ToArray();
        }
    }
}