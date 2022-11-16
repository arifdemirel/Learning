using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro_Strings();

            string sentence = "May neym iz Maykıl Sikkofiyıld";


            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My neym iz Lük Sıkayvalkır";



            bool result3 = sentence.EndsWith("ğ");

            bool result4 = sentence.StartsWith("v");

            var result5 = sentence.IndexOf("iz");   //search a text

            var result6 = sentence.IndexOf(" ");

            var result7 = sentence.LastIndexOf(" ");

            var result8 = sentence.Insert(8,"selam, ");

            var result9 = sentence.Substring(5);   //take the string from that array line forward

            var result10 = sentence.Substring(3, 5); // take from Xth array line forward y amount of chars

            var result11 = sentence.ToUpper();

            var result12 = sentence.ToLower();

            var result13 = sentence.Replace(" ", "-");

            var result14 = sentence.Remove(2,15);




            Console.WriteLine(result14);
            Console.WriteLine(result13);
            Console.WriteLine(result12);
            Console.WriteLine(result11);
            Console.WriteLine(result10);
            Console.WriteLine(result9);
            Console.WriteLine(result8);
            Console.WriteLine(result7);
            Console.WriteLine(result6);
            Console.WriteLine(result5);
            Console.WriteLine(result4);
            Console.WriteLine(result3);
            Console.WriteLine(result2);


            Console.ReadLine();
        }

        private static void Intro_Strings()
        {
            string city = "Ankara";
            string country = "Turkiye";
            Console.WriteLine(city[0] + " " + country[0]);


            foreach (var item in country)
            {
                Console.WriteLine(item);

            }


            string city2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
