using System.ComponentModel.DataAnnotations;

namespace PowerHouse.Models
{
    public class ImagesModel
    {

        public int Id { get; set; }
        [Required]
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }



    }
}
