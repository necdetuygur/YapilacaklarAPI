using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Data.Configurations
{
    class YapilacakConfiguration : IEntityTypeConfiguration<Yapilacak>
    {
        public void Configure(EntityTypeBuilder<Yapilacak> builder)
        {
            builder.HasKey(x => x.YapilacakID);
            builder.Property(x => x.YapilacakID).UseIdentityColumn();
            builder.Property(x => x.Baslik).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Yapildi).IsRequired();
            builder.ToTable("Yapilacak");
        }
    }
}
