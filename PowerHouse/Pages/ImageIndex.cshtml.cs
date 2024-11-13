using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PowerHouse.Models;

namespace PowerHouse.Pages
{
    public class ImageIndexModel : PageModel
    {
        public List<ImagesModel> ImagesModel { get; set; }
        public void OnGet()
        {
            ImagesModel = GetImages();
        }

        private List<ImagesModel> GetImages()
        {
            List<ImagesModel> list = new List<ImagesModel>();
            list.Add(new ImagesModel());
            list.Add(new ImagesModel());
            list.Add(new ImagesModel());

            return list;

        }
    }
}
