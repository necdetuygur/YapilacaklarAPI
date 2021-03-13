using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Data.Seeds
{
    class YapilacakSeed : IEntityTypeConfiguration<Yapilacak>
    {
        private readonly int[] _ids;
        public YapilacakSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Yapilacak> builder)
        {
            builder.HasData(
                new Yapilacak { YapilacakID = 1, Yapildi = false, Baslik = "Un al", Icerik = "Un al", Tarih = DateTime.Now, KullaniciID = _ids[0] },
                new Yapilacak { YapilacakID = 2, Yapildi = false, Baslik = "Süt al", Icerik = "Süt al", Tarih = DateTime.Now, KullaniciID = _ids[1] },
                new Yapilacak { YapilacakID = 3, Yapildi = false, Baslik = "Yoğurt al", Icerik = "Yoğurt al", Tarih = DateTime.Now, KullaniciID = _ids[2] }
            );
        }
    }
}
