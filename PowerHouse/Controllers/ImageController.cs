using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerHouse.Data;
using PowerHouse.Models;

namespace PowerHouse.Controlers
{
    public class ImageController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile imageFile, string title, string description)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            // Read image data into a byte array
            using (var memoryStream = new MemoryStream())
            {
                await imageFile.CopyToAsync(memoryStream);
                var imageData = memoryStream.ToArray();

                // Save image info to the database
                var blogImage = new ImagesModel
                {
                    FileName = imageFile.FileName,
                    Title = title,
                    Description = description,
                    ImageData = imageData,
                    ContentType = imageFile.ContentType
                };

                _context.imagesDbSet.Add(blogImage);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Home");
        }
    }

}

