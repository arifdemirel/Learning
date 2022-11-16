using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Bursa", "Afyon" }; //instance'a bellekte adres atandı  1001
            string[] cities2 = new string[] { "Ankara2", "Bursa2", "Afyon2" }; //instance'a bellekte ayrı adres atandı 1002
            cities2 = cities1;   //1002 = 1001 dediğimiz için artık 1002 yok. 1001 nesnesi ikisini de referanslıyor.
                                 // ve Garbage Collection 1002'yi bellekten silecektir
            cities1[0] = "istanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            dataTable2 = dataTable; // bunu dediğimiz için new instance'a gerek yok. ilk oluşturulan datatable redundant
            Console.ReadLine();
        }
    }
}
