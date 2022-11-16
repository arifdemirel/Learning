using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();



            Console.ReadLine();
        }

        class DataBase
        {
            public virtual void Add()
            {
                Console.WriteLine("Added By Default");
            }

            public virtual void Update()
            {
                Console.WriteLine("Updated By Default");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Deleted By Default");
            }

           
        }

        class SqlServer : DataBase
        {
            public override void Add()  //inherit edilen operasyonu bastırıp(ezip), yeni code'u çalıştırmak için
            {
                Console.WriteLine("Added by SqlCode");
                
                //base.Add();       base.Add() çalışırsa, her iki kod da etkin olur
            }
        }

        class MySqlServer : DataBase
        {

        }
    }
}
