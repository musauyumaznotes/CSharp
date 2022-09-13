using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EntityFramework
{
    public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity,bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Insert(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
