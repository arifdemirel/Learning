using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList();
            List();


            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("book", "kitap");
            dic.Add("table", "masa");
            dic.Add("computer", "bilgisayar");
            dic.Add("göt", "gürcan");

            //Console.WriteLine(dic["table"]);

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key); //item yerine item.Key yazarsak, key değere ulaşırız
                Console.WriteLine(item.Value);
                Console.WriteLine(dic.ContainsKey("Glass"));
                Console.WriteLine(dic.ContainsValue("kitap"));
            }


            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); // kullanmak istediğimiz veri tipini giriyoruz ve bu array sadece ilgili veri 
            cities.Add("Ankara");                     // tipini kabul eder
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara")); //ankara içeren şehir olmasaydı, false dönerdi



            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Arif" });
            customers.Add(new Customer { Id = 2, Name = "Mahmut" });



            var count = customers.Count;

            customers.Add(new Customer { Id = 3, Name = "Tosun" });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            //ya da

            var customer2 = new Customer { Id = 4, Name = "Sarıkız" };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]

            {
                /*  new Customer(),  */  new Customer{Id = 5, Name = "Sülo"}, // değerleri sonra vereceksek, en soldakini kullanırız
                /*  new Customer()   */  new Customer{Id = 6, Name = "Ali"}




            });
            Console.WriteLine(customers.Contains(new Customer { Id = 1, Name = "Engin" }));//instantiate yaparak çağırırsak hata alırız
            Console.WriteLine(customers.Contains(customer2));


            //customers.Clear();





            List<Customer> clients = new List<Customer>   // böyle de oluşturabiliriz
            {
                new Customer {Id = 1, Name = "Arif" },
                new Customer { Id = 2, Name = "Mahmut"}

            };


            customers.Add(customer2);

            customers.Insert(0, customer2);

            var index = customers.IndexOf(customer2);
            Console.WriteLine(index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine(index2);

            //customers.Remove(customer2);customers.Remove(customer2);
            customers.RemoveAll(c => c.Name == "Ali");


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + "Count : {0}", count);
            }
        }

        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        private static void ArrayList()
        {
            /*string[] cities = new string[2] { "Ankara", "İstanbul" };
                        cities = new string[3];
                        Console.WriteLine(cities[0]);*/

            ArrayList citiesList = new ArrayList();
            citiesList.Add("Ankara1");
            citiesList.Add("Ankara2");
            citiesList.Add("Ankara3");

            foreach (var city in citiesList)
            {
                Console.WriteLine(city);
            }
            citiesList.Add("Ankara4");
            citiesList.Add("Ankara5");
            citiesList.Add(1);
            citiesList.Add('A');
            Console.WriteLine(citiesList[3]);
        }
    }
}
