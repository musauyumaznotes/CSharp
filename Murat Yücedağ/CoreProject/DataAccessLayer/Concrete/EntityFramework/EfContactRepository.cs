using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
    }
}
