using InterFacesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };


            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek Başladı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Ödendi");
        }

        public void Work()
        {
            Console.WriteLine("Mesai Başladı");
        }
    }


    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yemek Başladı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Ödendi");
        }

        public void Work()
        {
            Console.WriteLine("Mesai Başladı");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Mesai Başladı");
        }
    }
}





