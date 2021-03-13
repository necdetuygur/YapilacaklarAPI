using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;

namespace Yapilacaklar.Data.Repositories
{
    public class YapilacakRepository : Repository<Yapilacak>, IYapilacakRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public YapilacakRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID)
        {
            return await _appDbContext.Yapilacaks.Include(x => x.Kullanici).SingleOrDefaultAsync(x => x.YapilacakID == YapilacakID);
        }
    }
}
