using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            TryCatch();
            //ActionDemo();

            Func<int, int, int> add = Add;

            Console.WriteLine(add(3, 5));   // buradaki add delege olarak kullanılıyor

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(0, 1000);
            };

            Console.WriteLine(getRandomNumber());
            //tek parametre varsa, parametresiz metodlara int döndürdüğü anlamına gelir/ ya da hangi veri tipini yazdıysak


            //Console.WriteLine(Add(2,3));

            Thread.Sleep(1000);
            Func<int> getRandomNumber2 = () => new Random().Next(0,1000);
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();

        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {

                Find();


            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {

            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private static void Find()
        {
            List<string> students = new List<string> { "Gürcan", "Sercan", "Arif" };

            if (!students.Contains("Ahmet"))
            {

                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {

                Console.WriteLine("Record Found");

            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Arif", "Gürcan", "Sercan" };

                students[3] = "Ahmet";

                Console.WriteLine(students[2]);

            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception) // bunu development da kullanırız
            {

                Console.WriteLine(exception.Message);  //ya da sadece exception

                Console.WriteLine(exception.InnerException);  //inner exception datamız olsaydı, hataya ilişkin ek bilgi gösterirdi
            }
            
        }
    }
}
