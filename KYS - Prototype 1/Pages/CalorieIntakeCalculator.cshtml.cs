using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KYS___Prototype_1.Pages.Shared
{
    public class CalorieIntakeCalculatorModel : PageModel
    {
        private readonly ILogger<CalorieIntakeCalculatorModel> _logger;

        public CalorieIntakeCalculatorModel(ILogger<CalorieIntakeCalculatorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
