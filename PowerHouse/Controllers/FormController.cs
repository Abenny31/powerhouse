using Microsoft.AspNetCore.Mvc;
using PowerHouse.Data;
using PowerHouse.Models;

namespace PowerHouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FormController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SubmitForm(FormData formData)
        {
            try
            {
                _context.formDataDbSet.Add(formData);
                _context.SaveChanges();
                return Ok(true);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetForms()
        {
            return Ok(_context.formDataDbSet.ToList());
        }
    }
}
