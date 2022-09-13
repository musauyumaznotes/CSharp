using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories.EntityFramework;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfWriterDal : EfGenericRepository<Writer, CoreBlogDbContext>, IWriterDal
    {
    }
}
