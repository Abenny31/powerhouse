using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PowerHouse.Controllers;
using PowerHouse.Data;
using PowerHouse.Models;

namespace PowerHouse.Pages
{
    public class KontaktModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public bool? Success { get; set; }

        private readonly FormController _formController;
        [BindProperty]
        public FormData FormData { get; set; }

        public KontaktModel(FormController formController)
        {
            _formController = formController;
        }
        public void OnGet()
        {
        }
 
        public IActionResult OnPost()
        {
            // Your logic for handling form submissions
            if (ModelState.IsValid)
            {
                if (_formController.SubmitForm(FormData))
                {
                    TempData["SubmissionSuccess"] = true;
                    Task.Delay(5000);
                    return RedirectToPage("Kontakt");
                }
                else
                    ModelState.AddModelError(string.Empty, "Nije uspjelo!.");
            }

            // If the model state is not valid, return the page with errors
            return Page();
        }

     

    }
}
