using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
