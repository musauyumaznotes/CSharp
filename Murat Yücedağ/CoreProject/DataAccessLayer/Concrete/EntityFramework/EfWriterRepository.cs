using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
    }
}
