using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T data)
        {
            var deletedEntity = context.Entry(data);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(data);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
           return _object.SingleOrDefault(filter);
        }

        public void Insert(T data)
        {
            var addedEntity = context.Entry(data);
            addedEntity.State = EntityState.Added;
            //_object.Add(data);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T data)
        {
            var updatedEntity = context.Entry(data);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
