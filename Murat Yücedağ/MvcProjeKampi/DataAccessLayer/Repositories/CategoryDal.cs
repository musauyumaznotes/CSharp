using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal : ICategoryDal
    {
        DbMvcCampContext context = new DbMvcCampContext();
        DbSet<Category> _object;
        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _object.ToList();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category category)
        {
            _object.Add(category);
            context.SaveChanges();
        }

        public List<Category> List()
        {
            throw new NotImplementedException();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
