using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Arif" }, new Customer { FirstName = "Demirel" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Product : IEntity
    {

    }

    class Customer : IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }

    /*interface IStudentDal : IRepository<CustomerDal>   //CustomerDall IEntity, yani veritabanı nesnesi olmadığı için hata alıyoruz
    {

    }*/

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T : class,IEntity, new()

        //burada "class" yazdığımzda, bununla interface eden tüm klaslar sadece "reference tip" alabilir
        //,new() yazarsak, bu nesnenin instantiate edilebilir olmasını sağlar. new() her zaman en sonda yer alır
        // IEntity'den implemenet edilmeli

        // sadece değer tipi koyulabilir yapmak isteseydik aşağıdaki gibi yapardık
        // interface IRepository<T> where T :struct
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }


    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
