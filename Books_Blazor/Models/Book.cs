using Books_Blazor.Models;
using System.ComponentModel.DataAnnotations;

namespace Books_Blazor.Models
{
    public class Book
    {
        [Required]
        public string Title { get; set; }
        public string Cover { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
