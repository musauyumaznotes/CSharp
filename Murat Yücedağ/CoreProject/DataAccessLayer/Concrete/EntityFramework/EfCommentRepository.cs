using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
    }
}
