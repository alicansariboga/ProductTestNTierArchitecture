using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.DataAccess;
using Test.Entities.Concrete;

namespace Test.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
