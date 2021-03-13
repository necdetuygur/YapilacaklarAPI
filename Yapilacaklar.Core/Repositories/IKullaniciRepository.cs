using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yapilacaklar.Core.Models;

namespace Yapilacaklar.Core.Repositories
{
    interface IKullaniciRepository:IRepository<Kullanici>
    {
        Task<Kullanici> GetWithYapilacaklarByIdAsync(int KullaniciID);
    }
}
