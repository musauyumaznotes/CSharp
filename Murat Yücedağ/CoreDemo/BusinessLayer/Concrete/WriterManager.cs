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
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer entity)
        {
            _writerDal.Insert(entity);
        }

        public void Delete(Writer entity)
        {
            _writerDal.Delete(entity);
        }

        public List<Writer> GetAll()
        {
            return _writerDal.GetAll();
        }

        public Writer GetById(int id)
        {
           return _writerDal.Get(x=>x.WriterId == id);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
