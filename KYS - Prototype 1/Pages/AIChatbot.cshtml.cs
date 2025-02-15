using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KYS___Prototype_1.Pages
{
    public class AIChatbotModel : PageModel
    {
        private readonly ILogger<AIChatbotModel> _logger;

        public AIChatbotModel(ILogger<AIChatbotModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
