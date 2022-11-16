using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();*
            //DoWhileLoop();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool _result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    _result = false;
                    i = number;
                }
                
            }
            return _result;
        }


        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number > 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= -100)
            {

                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("SIFIRA SIFIR, ELDE VAR SIFIR");

        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2) //i=i+2                 i--
            {
                Console.WriteLine(i);
                for (int j = 0; j <= 0; j++)
                {
                    Console.WriteLine("Kere");
                }
            }
        }
    }
}
