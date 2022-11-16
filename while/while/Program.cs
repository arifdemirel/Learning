using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 6; i++)
            {
                Random rnd = new Random();
                float num = rnd.Next(1,50);
                string sayisal = Math.Ceiling(num).ToString();
                
                Console.WriteLine(sayisal);
                
            }
            Console.ReadLine();
        }

        
    }
}
