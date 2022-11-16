using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager _customerManager = new CustomerManager();
            _customerManager.Add();
            _customerManager.Update();

            ProductManager _productManager = new ProductManager();
            _productManager.Add();
            _productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Gürcan";
            customer.LastName = "Ataselim";
            customer.Id = 1;
            customer.City = "Ankara";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Gürcan",
                LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
            

        }

    }
}
