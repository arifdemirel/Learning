using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetics arithmetics = new Arithmetics(2, 3);
            //Console.WriteLine(arithmetics.Add2());
            //Console.WriteLine(arithmetics.Add(2, 4));

            var type = typeof(Arithmetics);  //burada instantiate yapmıyoruz

            Arithmetics arithmetics = (Arithmetics)Activator.CreateInstance(type, 6, 7); // veya var Arithmetics = Activator.CreateInstance(type);
            Console.WriteLine(arithmetics.Add(4, 5));                     //burada istersek parametreliyi değişkenleri vererek çalıştırabiliriz (type,x,y,z)
            Console.WriteLine(arithmetics.Add2());
            //burada runtime anında instantiate yapmış oluyoruz 
            //Activator.CreateInstance nesne return eder

            var instance = Activator.CreateInstance(type, 6, 7);

            Console.WriteLine(instance.GetType().GetMethod("Multiply2").Invoke(instance, null));

            MethodInfo methodInfo = instance.GetType().GetMethod("Multiply2"); //yukarıda GetMethod'un yaptığı sadece bu. devamında instantiate ediyoruz bir üst kısımda
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("---------------------");

            var methods = type.GetMethods();  //birden fazla metodu çağrırıyoruz

            foreach (var info in methods)
            {
                Console.WriteLine("Method Name:{0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name:{0}", attribute.GetType().Name);
                }
            }


            Console.ReadLine();
        }
    }

    public class Arithmetics
    {

        int _number1;
        int _number2;
        public Arithmetics(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;

        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }


        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add2()
        {
            return _number1 + _number2;
        }

        [MethodName("Multiplication")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }

        public Arithmetics()
        {

        }

        public class MethodNameAttribute : Attribute
        {
            public MethodNameAttribute(string name)
            {

            }
        }
    }
}
