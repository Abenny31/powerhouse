using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using PowerHouse.Data;
using PowerHouse.Models;

namespace PowerHouse.Controllers
{
    public class FormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormController(ApplicationDbContext context)
        {
            _context = context;
        }


        public bool SubmitForm(FormData formData)
        {
            bool result = false;
            try
            {
                _context.formDataDbSet.Add(formData);
                _context.SaveChanges();

                result = true;
            }
            catch (Exception e)
            { 
            
            }
            return result;
        }
        //[HttpPost]
        //public IActionResult SubmitForm(FormData formData)
        //{
        //    // Save to the database
        //    _context.formDataDbSet.Add(formData);
        //    _context.SaveChanges();

        //    // You can add code here to send an email if needed



        //    // Return a partial view or JSON result if needed
        //    return RedirectToPage("/Kontakt", new { success = true });
        //}
    }
}
