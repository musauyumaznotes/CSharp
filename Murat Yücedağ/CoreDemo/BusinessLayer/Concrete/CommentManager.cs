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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public List<Comment> GetAll(int blogId)
        {
            return _commentDal.GetAll(x => x.BlogId == blogId);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.CommentId == id);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
