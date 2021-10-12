using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            decimal number2;
            string text;

            number1 = 10;
            number2 = 12.5m;
            text = "Szkoła Dotneta";

            Console.WriteLine($"Liczba całkowita: {number1}");
            Console.WriteLine($"Liczba zmiennoprzecinkowa: {number2}");
            Console.WriteLine($"Tekst: {text}");
        }
    }
}
