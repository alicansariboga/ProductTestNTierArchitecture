using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entities.Concrete;

namespace Test.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
