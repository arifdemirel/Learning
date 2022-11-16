using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            
            
            myDelegate -= customerManager.SendMessage; // -= kullandığımızda işlemi iptal ederiz

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
           myDelegate2+= customerManager.ShowAlert2;

            Arithmetics arithmetics = new Arithmetics();
            MyDelegate3 myDelegate3 = arithmetics.Multiply;
            myDelegate3 += arithmetics.Add;    //by delegenin return type'ı var ve bize tüm returnleri vermek yerine en son verdiğimizi gösterecektir.
            
            myDelegate3(5, 6);
            var result = myDelegate3(2, 3);
            Console.WriteLine(result);

            myDelegate();
            myDelegate2("Hello");

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("SM1");
        }

        public void ShowAlert()
        {
            Console.WriteLine("SA1");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Arithmetics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
