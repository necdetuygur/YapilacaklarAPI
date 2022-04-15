using System.ComponentModel.DataAnnotations;

namespace Yapilacaklar.API.DTOs
{
    public class BlogPostDto
    {
        public int BlogPostId { get; set; }
        [Required]
        public string Baslik { get; set; }
        public string Icerik { get; set; }
    }
}
