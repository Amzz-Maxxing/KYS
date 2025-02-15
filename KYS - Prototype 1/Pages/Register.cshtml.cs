using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KYS___Prototype_1.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(ILogger<RegisterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}