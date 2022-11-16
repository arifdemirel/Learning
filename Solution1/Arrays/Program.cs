using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] students = new string[3];

            students[0] = "Engin";
            students[1] = "Engin2";
            students[2] = "Engin3";


            string[] students2 = new[] { "Engin", "Engin2", "Engin3" };
            string[] students3 = { "Engin", "Engin2", "Engin3" };
            string[] students4 = new string[3] { "Engin", "Engin2", "Engin3" };

            foreach (var student in students2)
            {
                Console.WriteLine("Mal" + " " + student);

                Console.WriteLine(student);
            }

            Console.ReadLine();*/


            string[,] regions = new string[3, 3]
            {
                { "İstanbul","İzmit","Bursa" },
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},

            };
            //GetUpperBound(0) ilk düzlemin sayısına bakar, GetUpperBound(1) ise ikinci düzleme bakar
            for (int i = 0;
                i <= regions.GetUpperBound(0);
                i++)
            {
                for (int j = 0;
                    j < regions.GetUpperBound(1);
                    j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }
            Console.ReadLine();



        }
    }
}
