using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Repositories.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfBlogDal : EfGenericRepository<Blog, CoreBlogDbContext>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (CoreBlogDbContext context = new CoreBlogDbContext())
            {
                return context.Blogs.Include(x=> x.Category).ToList();
            }
        }
    }
}
