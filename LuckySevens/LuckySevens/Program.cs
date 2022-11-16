using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckySevens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalNumberOfSevens = 0;
            Random rng = new Random();

            int die1;
            int die2;

            for (int i = 1; i <= 100; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1, 7);

                if (die1 + die2 == 7)
                    TotalNumberOfSevens++;


                


            }
            Console.WriteLine("Yüz atımdan, {0} tanesi 7 etti", TotalNumberOfSevens);
            Console.ReadLine();

        }
    }
}
