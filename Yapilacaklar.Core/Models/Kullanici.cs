using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Yapilacaklar.Core.Models
{
    public class Kullanici
    {
        public Kullanici()
        {
            Yapilacaks = new Collection<Yapilacak>();
        }
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public ICollection<Yapilacak> Yapilacaks { get; set; }
    }
}
