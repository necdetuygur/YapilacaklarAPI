using System.Threading.Tasks;
using Yapilacaklar.Core.Models;
using Yapilacaklar.Core.Repositories;
using Yapilacaklar.Core.Services;
using Yapilacaklar.Core.UnitOfWorks;

namespace Yapilacaklar.Service.Services
{
    public class BlogPostService : Service<BlogPost>, IBlogPostService
    {
        public BlogPostService(IUnitOfWork unitOfWork, IRepository<BlogPost> repository) : base(unitOfWork, repository)
        {
        }
    }
}