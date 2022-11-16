using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program //birden fazla InterFace aynı class içinde implement edilebilir.
                           //Ancak, bir class sadece bir class'tan inherit edebilir.
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //üsttekinin yerine array ile yeni kişi/ler oluştururuz
            Person[] persons = new Person[3]
            {
                //new Customer(), new Student(), new Person()
                new Customer
                {Name= "Arif" },
                new Student
                {Name="Gürcan"},
                new Person
                {Name="Sercan"}

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }


    class Person2
    {

    }
}
