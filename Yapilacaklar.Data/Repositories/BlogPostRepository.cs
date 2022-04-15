using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;

namespace Yapilacaklar.Data.Repositories
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }
        public BlogPostRepository(AppDbContext context) : base(context)
        {
        }
    }
}
