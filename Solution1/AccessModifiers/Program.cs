using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        protected string City { get; set; } // tanımlanan yapı inherit edildiği sınıflarda kullanılabilir
        private string surName { get; set; } // tanımlanan yapı inherit edildiği sınıflarda kullanılamaz
        protected int Id;

        public void Save()
        {
            string name;
            Id++;
            surName = "Demirel";
            City = "İstanbul";
        }

        public void delete()
        {
            //name'e buradan erişemeyiz çünkü farklı bir scope ta yer alıyor
        }
    }

    class Student : Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            



        }
    }

    //internal class Course  //bir class'In default state'i Internal'dır
                           // internal modifier'lı bir class'ı referans ihtiyacı olmadan bağlı bulunduğu projede kullanabiliriz
                           // proje yerine(assembly)'de denir
                           // protected inheritance aldığı yerde de geçerlidir
                           // internal ise o proje içinde istediğimiz yerde çağırabileceğimiz anlamına gelir
                           // bir class ya internal olur ya da public olur

    public class Course
    {
        public string Name { get; set; }
        private class NestedClass //bu class sadece yukarıdaki class içerisinde kullanılabilir
        {

        }

        //AccessModifiers Solution Explorer view References section to be right clicked and "Add Reference" option
        // to be used. from there choose the project to be referenced
        // Also we should add "using" command with the project name. In our case, it is "using AccessModifiers"
        // ayrıca, ilgili class'ın public olması gerekmektedir.
    }
}
