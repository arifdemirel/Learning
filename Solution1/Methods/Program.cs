using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        public int j;
        static void Main(string[] args)
        {
            Add();
            var _result = Substract(20, 30);

            int a = 20;
            int b = 30;
            var _result2 = Multiply(a, b);
            Console.WriteLine(_result2);
            Console.ReadLine();

            Console.WriteLine(Divide(4,2,1));

            Console.WriteLine(Addition(2, 3, 4, 5, 6, 7, 8, 9));
           
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        //değişkene değer verilmezse default değer yandaki gibi verilir  static int Substract(int x, int y=20)  default değer en sonda olmalı

        static int Substract(int x, int y)
        {
            var result = x - y;
            return x - y;
        }
        // Ref tipi nedir bak --------------------MUTLAKA Ref varken variable için değer belirtmek zorunlu
        // Out tipi nedir bak --------------------MUTLAKA Out varken variable için değer belirtmek zorunlu değil
        static int Multiply(int a, int b)
        {
            a = 30;
            return a * b;
        }

        static int Divide(int t, int r, int u)
        {
            return t / r / u;
        }

        // static int Addition(int number,params int[]numbers)      non-param values first  -param values last
        static int Addition(params int[] numbers)
        {
            
            return numbers.Sum();
        }
        


    }
}
