using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            char sex;
            long pesel;
            long workerID;

            Console.WriteLine("Jak masz na imię?");
            //string name = "Hubert";
            name = Console.ReadLine();

            Console.WriteLine("Jak masz na nazwisko?");
            //string surname = "Janicki";
            surname = Console.ReadLine();

            Console.WriteLine("Twój wiek?");
            //int age = 32;
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Twoja płeć? (m - mężczyzna, k - kobieta)");
            //string sex = "m";
            sex = char.Parse(Console.ReadLine());

            Console.WriteLine("Jaki jest twój PESEL?");
            //long pesel = 89121400000;
            pesel = long.Parse(Console.ReadLine());

            Console.WriteLine("Jaki jest twój numer pracownika?");
            //long workerID = 3123456789;
            workerID = long.Parse(Console.ReadLine());

            Console.WriteLine($"Pracownik miesiąca to: \r\n Imię: {name} \r\n Nazwisko: {surname} \r\n Wiek: {age} \r\n Płeć: {sex} \r\n PESEL (we trust in your honesty): {pesel} \r\n Nr pracownika: {workerID} \r\n ");
        }
    }
}
