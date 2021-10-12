using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie do obliczenia długości przekątnej prostokąta.");

            Console.WriteLine("Podaj szerokość prostokąta: ");
            string width = Console.ReadLine();
            Console.WriteLine("Podaj długość prostokąta: ");
            string length = Console.ReadLine();

            int widthNumber;
            int lengthNumber;

            Int32.TryParse(width, out widthNumber);
            Int32.TryParse(length, out lengthNumber);

            double widthPower = Math.Pow(widthNumber, 2);
            double lengthPower = Math.Pow(lengthNumber, 2);
            double diagonal = Math.Sqrt(widthPower + lengthPower);
            Console.WriteLine($"Obliczona przekątna prostokąta wynosi: {diagonal}.");
        }
    }
}
