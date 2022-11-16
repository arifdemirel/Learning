using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Conditionals
    {
        static void Main(string[] args)
        {
            /*var number = 11;
            if(number==10)
            {
                Console.WriteLine("The number is {0}",number);
            }
            else
            {
                Console.WriteLine("Where is the money, Lebowski!");
            }*/


            //var number = 11;
            //SINGLE LINE IF
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


            /*var number = 11;
                            if(number == 10)
                        {
                            Console.WriteLine("Number is 10");
                        }
                        else if (number == 20)
                        {
                            Console.WriteLine("Number is 25");
                        }
                        else
                        {
                            Console.WriteLine("Number is not 10 or 25");
                        }*/

            /*var number = 11;
            switch (number)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                case 20:
                    Console.WriteLine("20");
                    break;
                default:
                    Console.WriteLine("BOSCH");
                    break;
            }*/



            /*var number = 250;
            if(number>=0 && number <=100)
            {
                Console.WriteLine("Yüzden küçük ve Sıfırdan Büyüktür");
            }
            else if(number>100 && number<=200)
            {
               Console.WriteLine("İkiyüzden küçük ve Yüzden Büyüktür");
            }
            else if (number>200 || number <0 )
            {
                Console.WriteLine("Mazlum'u Getirin Bana");
            }*/

            var number = 100;

            if(number<100)
            {
                if(number>=90)
                {
                    if(number>=70)
                    {
                        Console.WriteLine("Yetmez ama yetsin");
                        if(number>=50)
                        {
                            Console.WriteLine("Bokunu Çıkardın");
                            
                        }
                    }
                    Console.WriteLine("Yuck Fou");
                }
                else
                {
                    Console.WriteLine("bas git");
                }
            }

            Console.ReadLine();
            
        }
    }
}
