using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerHouse.Data;
using PowerHouse.Models;

namespace PowerHouse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile imageFile, string title, string description)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            using var memoryStream = new MemoryStream();
            await imageFile.CopyToAsync(memoryStream);
            var blogImage = new ImagesModel
            {
                FileName = imageFile.FileName,
                Title = title,
                Description = description,
                ImageData = memoryStream.ToArray(),
                ContentType = imageFile.ContentType
            };
            _context.imagesDbSet.Add(blogImage);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetImages()
        {
            return Ok(_context.imagesDbSet.ToList());
        }
    }
}
