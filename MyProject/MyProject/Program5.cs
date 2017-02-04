/*Write a program using a switch statement that takes one value from the user and asks about the type of conversion and then performs a conversion depending on the type of conversion. If user enters:

I -> convert from inches to centimeters.
G -> convert from gallons to liters.
M -> convert from mile to kilometer.
P -> convert from pound to kilogram.

If the user enters any other character then show a proper message.*/
using System;
namespace MyProject
{
    class Program5
    {
        static void Main(string[] args)
        {
            double value;
            char choice;
            double cm, l, km, kg;
            Console.Write("Enter the value to be converted: ");
            value = double.Parse(Console.ReadLine());
            Console.Write("Enter the unit: ");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
                {
                case 'I' : cm = value / 0.3937;
                    Console.WriteLine("Centimeter: "+cm);
                    break;
                case 'i':
                    cm = value / 0.3937;
                    Console.WriteLine("Centimeter: " + cm);
                    break;
                case 'G':
                    l = value * 3.78;
                    Console.WriteLine("Litre:" + l);
                    break;
                case 'g':
                    l = value * 3.78;
                    Console.WriteLine("Litre: " + l);
                    break;
                case 'M':
                    km = value * 1.60;
                    Console.WriteLine("Kilometer: " + km);
                    break;
                case 'm':
                    km = value * 1.60;
                    Console.WriteLine("Kilometer: " + km);
                    break;
                case 'P':
                    kg = value * 0.453;
                    Console.WriteLine("Kilogram: " + kg);
                    break;
                case 'p':
                    kg = value * 0.453;
                    Console.WriteLine("Kilogram: " + kg);
                    break;
            }
            Console.ReadLine();
        }
    }
}
