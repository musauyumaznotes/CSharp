using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfABlogRepository : GenericRepository<Blog>, IBlogDal
    {
    }
}
