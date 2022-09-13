using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
        T Get(Expression<Func<T,bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

    }
}
