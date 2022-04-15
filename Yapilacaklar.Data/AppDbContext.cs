using Microsoft.EntityFrameworkCore;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Data.Configurations;
using Yapilacaklar.Data.Seeds;

namespace Yapilacaklar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Yapilacak> Yapilacaks { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Foreign keylerde
            modelBuilder.ApplyConfiguration(new YapilacakConfiguration());
            modelBuilder.ApplyConfiguration(new KullaniciConfiguration());
            modelBuilder.ApplyConfiguration(new YapilacakSeed(new int[] {1, 2, 3}));
            modelBuilder.ApplyConfiguration(new KullaniciSeed(new int[] {1, 2, 3}));
        }
    }
}