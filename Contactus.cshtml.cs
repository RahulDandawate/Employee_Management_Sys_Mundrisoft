using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RD.Pages;

public class ContactusModel : PageModel
{
    private readonly ILogger<ContactusModel> _logger;

    public ContactusModel(ILogger<ContactusModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}