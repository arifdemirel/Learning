using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DataBaseLogger();
            //customerManager.Logger = new FileLogger();
            //customerManager.Logger = new SmsLogger();
            //only the last one works(it overrides the previous ones)
            customerManager.Add();
            

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            //Logger logger = new Logger();
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DataBaseLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
