using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingId(int id);
        List<Content> GetListByWriter(int id);
        Content GetById(int id);
        void AddContent(Content content);
        void DeleteContent(Content content);
        void UpdateContent(Content content);
    }
}
