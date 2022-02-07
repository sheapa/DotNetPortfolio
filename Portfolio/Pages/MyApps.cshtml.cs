using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class MyAppsModel : PageModel
    {
        private readonly ILogger<MyAppsModel> _logger;

        public MyAppsModel(ILogger<MyAppsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}