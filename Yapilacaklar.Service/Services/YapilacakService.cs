using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;
using Yapilacaklar.Core.Services;
using Yapilacaklar.Core.UnitOfWorks;

namespace Yapilacaklar.Service.Services
{
    public class YapilacakService : Service<Yapilacak>, IYapilacakService
    {
        public YapilacakService(IUnitOfWork unitOfWork, IRepository<Yapilacak> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID)
        {
            return await _unitOfWork.Yapilacaks.GetWithKullaniciByIdAsync(YapilacakID);
        }
    }
}
