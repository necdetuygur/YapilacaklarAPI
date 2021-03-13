using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Services
{
    public interface IYapilacakService : IService<Yapilacak>
    {
        Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID);
    }
}
