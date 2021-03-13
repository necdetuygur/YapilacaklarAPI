using System;

namespace Yapilacaklar.Core.Models
{
    class Yapilacak
    {
        public int YapilacakID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Yapildi { get; set; }
        public int KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
