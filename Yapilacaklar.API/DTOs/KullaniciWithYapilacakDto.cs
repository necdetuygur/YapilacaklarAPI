using System.Collections.Generic;

namespace Yapilacaklar.API.DTOs
{
    public class KullaniciWithYapilacakDto : KullaniciDto
    {
        public ICollection<YapilacakDto> Yapilacaks { get; set; }
    }
}
