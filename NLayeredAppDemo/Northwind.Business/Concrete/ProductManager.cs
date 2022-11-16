using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using Northwind.DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Business.Abstract;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }




        //EfProductDal _productDal = new EfProductDal();
        public List<Product> GetAll()
       
        {
            //Business Code
           
            return _productDal.GetAll();
        }
    }
}
