using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Repositories
{
    interface IYapilacakRepository : IRepository<Yapilacak>
    {
        Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID);
    }
}
