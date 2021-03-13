using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;
using Yapilacaklar.Core.Services;
using Yapilacaklar.Core.UnitOfWorks;

namespace Yapilacaklar.Service.Services
{
    public class KullaniciService : Service<Kullanici>, IKullaniciService
    {
        public KullaniciService(IUnitOfWork unitOfWork, IRepository<Kullanici> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Kullanici> GetWithYapilacaksByIdAsync(int KullaniciID)
        {
            return await _unitOfWork.Kullanicis.GetWithYapilacaksByIdAsync(KullaniciID);
        }
    }
}
