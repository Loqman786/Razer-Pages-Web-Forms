using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razer_pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Mohammed";
        }

        public void Onpost()
        {
            if(String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["NoName"] = "You have not entered a name!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Messege"] = "Name is Registered!";
                // Register the user
            }
        }
    }
}