using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Data.Seeds
{
    public class KullaniciSeed : IEntityTypeConfiguration<Kullanici>
    {
        private readonly int[] _ids;
        public KullaniciSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(
                new Kullanici { KullaniciID = _ids[0], Ad = "Ahmet", Soyad = "Yılmaz"},
                new Kullanici { KullaniciID = _ids[1], Ad = "Mehmet", Soyad = "Yılmaz"},
                new Kullanici { KullaniciID = _ids[2], Ad = "Ayşe", Soyad = "Yılmaz"}
            );
        }
    }
}
