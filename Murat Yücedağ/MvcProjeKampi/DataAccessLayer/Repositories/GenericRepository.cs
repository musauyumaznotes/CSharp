using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IRepositoryDal<TEntity> where TEntity : class, new()
    {
        DbSet<TEntity> _object;
        DbMvcCampContext context = new DbMvcCampContext();
        public GenericRepository()
        {
            _object = context.Set<TEntity>(); 
        }
        public void Delete(TEntity entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(TEntity entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public List<TEntity> List()
        {
            return _object.ToList();
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            context.SaveChanges();
        }
    }
}
