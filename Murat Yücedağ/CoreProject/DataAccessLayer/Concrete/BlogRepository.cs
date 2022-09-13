using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Concrete
{
    public class BlogRepository : IBlogDal
    {

        public void AddBlog(Blog blog)
        {
            using (var c = new CoreBlogDbContext())
            {
                c.Add(blog);
                c.SaveChanges();
            }
        }

        public void DeleteBlog(Blog blog)
        {
            using (var c = new CoreBlogDbContext())
            {
                c.Remove(blog);
                c.SaveChanges(); ;
            }
        }

        public List<Blog> GetAll()
        {
            using (var c = new CoreBlogDbContext())
            {
                return c.Blogs.ToList();
            }
            
        }

        public Blog GetById(int id)
        {
            using (var c = new CoreBlogDbContext())
            {
               return c.Blogs.Find(id);
            }
        }

        public void UpdateBlog(Blog blog)
        {
            using (var c = new CoreBlogDbContext())
            {
                c.Update(blog);
                c.SaveChanges(); ;
            }
        }
    }
}
