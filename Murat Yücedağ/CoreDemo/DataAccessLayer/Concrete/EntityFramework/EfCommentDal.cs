using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentDal : EfGenericRepository<Comment, CoreBlogDbContext>, ICommentDal
    {
    }
}
