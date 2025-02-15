using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KYS___Prototype_1.Pages
{
    public class HelpModel : PageModel
    {
        private readonly ILogger<HelpModel> _logger;

        public HelpModel(ILogger<HelpModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
