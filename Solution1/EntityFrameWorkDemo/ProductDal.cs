using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFrameWorkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList(); //böyle yaparsak veri tabanından sorgularız -- form sayfasındaki ise, tabloya halihazırda getirilmiş olan DataGrid üzerinde arama yaparız.
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList(); //böyle yaparsak veri tabanından sorgularız -- form sayfasındaki ise, tabloya halihazırda getirilmiş olan DataGrid üzerinde arama yaparız.
            }
        }

        public List<Product> GetByPriceRange(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList(); //böyle yaparsak veri tabanından sorgularız -- form sayfasındaki ise, tabloya halihazırda getirilmiş olan DataGrid üzerinde arama yaparız.
            }
        }

        public Product GetById(int id) //burada diğerlerinin aksine List kullanmıyoruz, çünkü tek bir girdiyi çağırıyoruz
        {
            using (ETradeContext context = new ETradeContext())
            {
               var result = context.Products.FirstOrDefault(p=>p.Id == id);
                return result;
            }
        }

        public Product GetById2(int id) //burada diğerlerinin aksine List kullanmıyoruz, çünkü tek bir girdiyi çağırıyoruz
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.SingleOrDefault(p => p.Id == id); //
                return result;
            }
        }


        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();


                //var entity = context.Entry(product);          bu şekilde ürün ekleme yapabiliriz
                //entity.State = EntityState.Added;
                //context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }


        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
