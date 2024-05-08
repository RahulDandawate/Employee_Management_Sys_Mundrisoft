using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RD.Pages;

public class ForgotpassModel : PageModel
{
    private readonly ILogger<ForgotpassModel> _logger;

    public ForgotpassModel(ILogger<ForgotpassModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}