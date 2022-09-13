using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        public void Delete(TEntity entity)
        {
            using (var context = new CoreBlogDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new CoreBlogDbContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> GetListAll()
        {
            using (var context = new CoreBlogDbContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using (var context = new CoreBlogDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new CoreBlogDbContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
