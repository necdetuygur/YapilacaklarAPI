using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Services
{
    public interface IKullaniciService : IService<Kullanici>
    {
        Task<Kullanici> GetWithYapilacaklarByIdAsync(int KullaniciID);
    }
}
