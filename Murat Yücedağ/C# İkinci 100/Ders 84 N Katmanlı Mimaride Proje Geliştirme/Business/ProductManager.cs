using DataAccess;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class ProductManager
    {
        Repository<Product> repoProduct = new Repository<Product>();

        public List<Product> GetAll()
        {
            return repoProduct.List();
        }
    }
}
