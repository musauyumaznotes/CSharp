using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithWriter(int writerId)
        {
            return _blogDal.GetAll(x => x.WriterId == writerId);
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(b => b.BlogId == id);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
