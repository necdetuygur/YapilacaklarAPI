using System.ComponentModel.DataAnnotations;

namespace Yapilacaklar.API.DTOs
{
    public class KullaniciDto
    {

        public int KullaniciID { get; set; }
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
