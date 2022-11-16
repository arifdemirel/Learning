using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal
{

    public class While
    {
        int number1 = 0;

        public void Vile(string[] args)
        {
            while(number1<=10)
            {
                number1 = number1 + 1;
                Console.WriteLine(number1);
                Console.ReadLine();
            }
        }
    }
}
