using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_console_app
{
    internal class Person
    {

        string name;
        string nazwisko;
        string miejsce;
        int year;
        int month;
        int day;
        int wiek;
        int months;
        int days;
        public Person(string name,string nazwisko,string miejsce,int year,int month,int day)

        {
            this.name = name;
            this.nazwisko = nazwisko;
            this.miejsce = miejsce;
            this.year = year;
            this.month = month;
            this.day = day;

        }

        

        public void Age()
        {
            days = DateTime.Now.Day - this.day;
            months = DateTime.Now.Month - this.month;
            wiek = DateTime.Now.Year - this.year;
            if (months<0 ||days<0)
            {
               wiek= wiek - 1;
            }
            
           
            Console.WriteLine("wiek to " + wiek + " "+"lat");
        }
        public void PersonMethod()
        {
            Console.WriteLine($"Imie to {name} nazwisko to {nazwisko} miejsce urodzin {miejsce}");
            Age();
        }

    }
}
