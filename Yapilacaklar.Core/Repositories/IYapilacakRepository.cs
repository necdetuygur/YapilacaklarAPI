using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Repositories
{
    public interface IYapilacakRepository : IRepository<Yapilacak>
    {
        Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID);
    }
}
