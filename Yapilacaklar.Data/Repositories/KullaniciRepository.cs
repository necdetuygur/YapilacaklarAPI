using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;

namespace Yapilacaklar.Data.Repositories
{
    public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public KullaniciRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Kullanici> GetWithYapilacaklarByIdAsync(int KullaniciID)
        {
            return await _appDbContext.Kullanicis.Include(x => x.Yapilacaks).SingleOrDefaultAsync(x => x.KullaniciID == KullaniciID);
        }
    }
}
