using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //aşağıda overload yaptığım için burada constructor'a parametre yazmama gerek yok
            customerManager.List();

            // Product product = new Product();  veya aşağıdaki gibi
            //Product product = new Product { Id = 1, Name = "Desktop" };     // veta
            Product product2 = new Product(2,"Smartphone");


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            
            employeeManager.Add();

            PersonManager personmanager = new PersonManager("Product");
            personmanager.Remove();
            personmanager.Add();
            
            
            Teacher.Number = 10; // static object, if defined will have the same value for all the other classes within the application
            // static objects are shared objects

            Utilities.Validate();

            Manager.DoSomething(); //static böyle çağrılır

            Manager _manager = new Manager();
            _manager.DoSomething2();   //aynı class(class static değil) içindeki static olmayan metodu ise instantiate yaparak çağırırız

            // static constructorlar'da da aynı şeyi yapabiliriz

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;  //private field alt çizgi ile başlatılır // method satırındaysa alt çizgi kullanılmaz
        public CustomerManager(int count)
        {
            _count = count;
        }

        // ctor çift Tab
        //constructorlar overload edilebilir
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        
        
        public int Id { get; set; }
        public string Name { get; set; }
    }



    interface IKutukcu
    {
        void Log();
    }


    class DatabaseLogger: IKutukcu
    {
        public void Log()
        {
            Console.WriteLine("Logged To database");
        }
    }


    class FileLogger : IKutukcu
    {
        public void Log()
        {
            Console.WriteLine("Logged To file");
        }
    }

    class EmployeeManager
    {
        private IKutukcu _kutukcu;
        public EmployeeManager(IKutukcu kutukcu)
        {
            _kutukcu = kutukcu;
        }
        public IKutukcu Kutukcu { get; set; }
        public void Add()
        {
            _kutukcu.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
            
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) :base(entity)
        {
            
        }

        public void Remove()
        {
            Console.WriteLine("Removed");
            Message();
        }
        
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    // birden fazla parametreli constructor ekleyebilirim, fakat aldıkları veri tipleri ya da sayısı (parametre sayısı)farklı olmalı

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // this way we can provide default values and we can do it with any type
    }

    static class Teacher // you can't instantiate a static object //
    {
        public static int Number { get; set; }
    }


    static class Utilities
    {

        static Utilities()
        {
            Console.WriteLine("static constructor çalıştı");
        }
        public static void Validate()
        {
            Console.WriteLine("Invalid");
        }
    }


    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("DONE");
        }

        public void DoSomething2()
        {
            Console.WriteLine("DONE2");
        }
    }



}
