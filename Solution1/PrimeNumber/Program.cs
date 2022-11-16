﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
    }
}
