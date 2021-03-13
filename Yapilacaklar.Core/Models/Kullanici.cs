using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Yapilacaklar.Core.Models
{
    class Kullanici
    {
        public Kullanici()
        {
            Yapilacaklar = new Collection<Yapilacak>();
        }
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public ICollection<Yapilacak> Yapilacaklar { get; set; }
    }
}
