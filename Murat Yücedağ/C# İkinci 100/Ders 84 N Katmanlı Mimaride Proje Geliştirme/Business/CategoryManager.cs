using DataAccess;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager//Süzgeç
    {
        Repository<Category> caterepo = new Repository<Category>();

        public List<Category> GetAll()
        {
            return caterepo.List();
        }
        public int BLAdd(Category c)
        {
            if (c.CategoryName.Length <= 3)
            {
                return -1;
            }
            return caterepo.Insert(c);
        }
        public int BLDelete(int p)
        {
            if (p != 0)
            {
                Category c = caterepo.Find(x => x.CategoryId == p);
                return caterepo.Delete(c);
            }
            else
            {
                return -1;
            }
        }
        public int BLUpdate(Category c)
        {
            if (c.CategoryName == "" || c.CategoryName.Length <= 3 || c.CategoryName.Length >= 30)
            {
                return -1;
            }
            Category ct = caterepo.Find(x=>x.CategoryId==c.CategoryId);
            ct.CategoryName = c.CategoryName;
            
        }
    }
}
