using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Repositories
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        Task<Kullanici> GetWithYapilacaksByIdAsync(int KullaniciID);
    }
}
