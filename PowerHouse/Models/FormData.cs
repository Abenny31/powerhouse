using System.ComponentModel.DataAnnotations;

namespace PowerHouse.Models
{
    public class FormData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime TimeStamp { get; set; }


    }
}
