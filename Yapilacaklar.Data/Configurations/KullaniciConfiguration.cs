using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Data.Configurations
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.KullaniciID);
            builder.Property(x => x.KullaniciID).UseIdentityColumn();
            builder.Property(x => x.Ad).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Soyad).IsRequired().HasMaxLength(50);
            builder.ToTable("Kullanici");
        }
    }
}
