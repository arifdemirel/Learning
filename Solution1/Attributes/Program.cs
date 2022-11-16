using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Engin", Age = 32 };
            CustomerlDal customerDal = new CustomerlDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")] //bu yapı dinamik sorgular için kullanılır // sql insert sorgusu
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        [RequiredProperty]  //AllowMultiple false olsaydı aynı attribute'u iki kez kullanamazdık
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerlDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }


        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }


    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]    //attribute class'ına da attribute atayabiliriz // AttributeTargets.All yerine Attribute.Class deseydik kullanım kısıtlanırdı [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] 
    class RequiredPropertyAttribute: Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;

        }
    }

    
}
