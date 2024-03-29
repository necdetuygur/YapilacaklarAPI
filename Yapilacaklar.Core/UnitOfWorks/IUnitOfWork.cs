﻿using System.Threading.Tasks;
using Yapilacaklar.Core.Repositories;

namespace Yapilacaklar.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IYapilacakRepository Yapilacaks { get; }
        IKullaniciRepository Kullanicis { get; }
        IBlogPostRepository BlogPosts { get; }
        Task CommitAsync();
        void Commit();
    }
}
