using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace codewars3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number;
            string result;

            Console.Write("Type An Integer");
            number = int.Parse(Console.ReadLine());


            if(number>0)
            {
                result = "Positive";
            }
            else if (number < 0)
            {
                result = "Negative";
                
            }
            else
            {
                result = "Zero";
            }

            Console.Write(result);
            Console.ReadLine();
        }




    }
}
