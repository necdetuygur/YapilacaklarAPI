using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Services;
using Yapilacaklar.Core.UnitOfWorks;

namespace Yapilacaklar.Service.Services
{
    class YapilacakService : IYapilacakService
    {
        private readonly IUnitOfWork _unitOfWork;
        public YapilacakService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Yapilacak> AddAsync(Yapilacak entity)
        {
            await _unitOfWork.Yapilacaks.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<Yapilacak>> AddRangeAsync(IEnumerable<Yapilacak> entities)
        {
            await _unitOfWork.Yapilacaks.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<IEnumerable<Yapilacak>> Where(Expression<Func<Yapilacak, bool>> predicate)
        {
            return await _unitOfWork.Yapilacaks.Where(predicate);
        }

        public async Task<IEnumerable<Yapilacak>> GetAllAsync()
        {
            return await _unitOfWork.Yapilacaks.GetAllAsync();
        }

        public async Task<Yapilacak> GetByIdAsync(int id)
        {
            return await _unitOfWork.Yapilacaks.GetByIdAsync(id);
        }

        public async Task<Yapilacak> GetWithKullaniciByIdAsync(int YapilacakID)
        {
            return await _unitOfWork.Yapilacaks.GetWithKullaniciByIdAsync(YapilacakID);
        }

        public void Remove(Yapilacak entity)
        {
            _unitOfWork.Yapilacaks.Remove(entity);
            _unitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<Yapilacak> entities)
        {
            _unitOfWork.Yapilacaks.RemoveRange(entities);
            _unitOfWork.Commit();
        }

        public async Task<Yapilacak> SingleOrDefaultAsync(Expression<Func<Yapilacak, bool>> predicate)
        {
            return await _unitOfWork.Yapilacaks.SingleOrDefaultAsync(predicate);
        }

        public Yapilacak Update(Yapilacak entity)
        {
            var updateYapilacak = _unitOfWork.Yapilacaks.Update(entity);
            _unitOfWork.Commit();
            return updateYapilacak;
        }
    }
}
