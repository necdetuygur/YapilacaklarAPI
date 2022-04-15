using System.Threading.Tasks;
using Yapilacaklar.Core.Repositories;
using Yapilacaklar.Core.UnitOfWorks;
using Yapilacaklar.Data.Repositories;

namespace Yapilacaklar.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private YapilacakRepository _yapilacakRepository;
        private KullaniciRepository _kullaniciRepository;
        private BlogPostRepository _blogPostRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IYapilacakRepository Yapilacaks => _yapilacakRepository = _yapilacakRepository ?? new YapilacakRepository(_context);

        public IKullaniciRepository Kullanicis => _kullaniciRepository = _kullaniciRepository ?? new KullaniciRepository(_context);
        public IBlogPostRepository BlogPosts => _blogPostRepository = _blogPostRepository ?? new BlogPostRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
