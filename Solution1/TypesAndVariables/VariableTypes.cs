using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text1 = "Ankara";
            char numberminus2 = 'A';
            bool numberminus1 = true;
            byte number0 = 255;
            short number1 = -32767;
            int number2 = -2147483647;
            long number3 = -9223372036854775807;
            double number4 = 10.4f;
            decimal number5 = 10.4m;

            //string dışındaki değişkenleri kendiliğinden alır
            var number6 = 10000000000000000000;
            var number7 = 'A';

            Console.WriteLine("Gürcan'ın yaşı {0}{1}{2}{3}{4}{5}{6}{7}", numberminus1, number0, number1, number2, number3, (int)numberminus2, text1, number4, number5);

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.ReadLine();
        }
        //aksi belirtilmedikçe, sıra numarası Array'lerdeki gibi ilerler
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Seasons
        {
            Summer = 10, Autumn = 20, Winter = 30, Spring
        }


    }
}
