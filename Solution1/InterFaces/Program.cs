using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
//using static InterFaces.OracleServerCustomerDal;  // bunları sola eklemeden interface çalışmadı
//yukarıdaki açıklama gereksiz. ben bu ICustomerDal oluşturduğum "CustomerManager" class'ını başka bir sınıf içinde oluşturduğum için,
// bu taraftan üstte yer alan "using" komutu olmadan erişemiyordum. hata yaptık mal gibi


namespace InterFaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterFacesIntro();

            //IPerson person = new Customer();    //Interface ile yeni nesne oluşturamayız. diğer classlardan yararlanıp
            //onların nesnelerini oluştururlar.
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customer = new CustomerManager();
            customer.Add(new SqlServerCustomerDal());
            customer.Add(new OracleServerCustomerDal());

            Console.ReadLine();
        }

        private static void InterFacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, Name = "Arif", Surname = "Demirel", Address = "İstanbul" });


            //böyle de yazabiliriz
            /*
               Customer customer = new Customer
            {
                Id = 1,
                Name = "Arif",
                Surname = "Demirel",
                Address = "İstanbul"
            }
            manager.Add(new Customer{});
            */

            Student student = new Student
            {
                Id = 1,
                Name = "Gürcan",
                Surname = "Ataselim",
                Department = "Computer Sciences"
            };
            manager.Add(student);

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }

        string Surname { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson customer)    // iperson yerine  Customer ya da Student yazsaydık, sadece ilgili class'tan verirdi.

        //IPerson kullanınca (interface ile) mirasçıların hepsini çağırılacak bilgilerin kapsamına aldı
        {
            Console.WriteLine(customer.Name, customer.Surname);
        }
    }

    class Employee : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public string Department { get; set; }
    }
}
