using Microsoft.EntityFrameworkCore;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Data.Configurations;

namespace Yapilacaklar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Yapilacak> Yapilacaks { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new YapilacakConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciConfiguration());
        }
    }
}
