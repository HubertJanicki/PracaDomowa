using System;

namespace PracaDomowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Transhumanity Center!\n Before we can proceed with your implants order, please answer questionnaire below.");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("What is your email?");
            string eMail = Console.ReadLine();
            Console.WriteLine("What is your height [m]?");
            string height = Console.ReadLine();
            Console.WriteLine("What is your weight [kg]?");
            string weight = Console.ReadLine();

            int resultAge = Int32.Parse(age);
            int resultPhoneNumber = Int32.Parse(phoneNumber);
            decimal resultHeight = Decimal.Parse(height);
            decimal resultWeight = Decimal.Parse(weight);

            Console.WriteLine("\nThank you for filling questionnaire.\nPlease, check if you implemented correct data before placing an order.");
            Console.WriteLine($" Name: {name}\n Surname: {surname}\n Age: {resultAge}\n Phone number: {resultPhoneNumber}\n Email: {eMail}\n Height: {resultHeight}\n Weight: {resultWeight}");
        }
    }
}
