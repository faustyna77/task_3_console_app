using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_console_app
{
    class Program
    {
       
        public static void Main()
        {
            Console.WriteLine("podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("podaj nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("podaj miejsce");
            string miejsce = Console.ReadLine();
            Console.WriteLine("podaj rok");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj miesiac ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dzień ");
            int day = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(imie, nazwisko,miejsce,year,month,day);
          
            person.PersonMethod();
        }

    }
}
