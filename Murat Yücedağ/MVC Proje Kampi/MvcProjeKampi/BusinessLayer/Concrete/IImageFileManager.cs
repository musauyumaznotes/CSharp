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
    public class IImageFileManager : IImageFileService
    {
        IImageFileDal _imageFileDal;

        public IImageFileManager(IImageFileDal imageFileDal)
        {
            _imageFileDal = imageFileDal;
        }

        public ImageFile GetById(int id)
        {
            return _imageFileDal.Get(x=>x.Id==id);
        }

        public List<ImageFile> GetList()
        {
            return _imageFileDal.List();
        }

        public void ImageFileAdd(ImageFile imageFile)
        {
            _imageFileDal.Insert(imageFile);
        }

        public void ImageFileDelete(ImageFile imageFile)
        {
            _imageFileDal.Delete(imageFile);
        }

        public void ImageFileUpdate(ImageFile imageFile)
        {
            _imageFileDal.Update(imageFile);
        }
    }
}
