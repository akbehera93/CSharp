//program that takes a character from the user and determines whether the character entered is a capital letter, a small case letter, a digit or a special symbol.
using System;
namespace MyProject
{
    class Program4
    {
        static void Main()
        {
            char ch='0';
            int ascii;
            Console.Write("Enter a character: ");
            try
            {
                ch = Convert.ToChar(Console.ReadLine());
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("INVALID CHARACTER is entered");
                goto ExitLabel;
            }
            ascii = ch;
            Console.WriteLine("The ASCII value for "+ch+" is: "+ascii);
            if (ascii >= 65 && ascii <= 90)
                Console.WriteLine(ch + " is an UPPER CASE english alphabet");
            else if (ascii >= 97 && ascii <= 122)
                Console.WriteLine(ch + " is a LOWER CASE english alphabet");
            else if (ascii >= 48 && ascii <= 57)
                Console.WriteLine(ch + " is a DIGIT");
            else if (ascii == 32)
                Console.WriteLine("A BLANK SPACE is being entered");
            else
                Console.WriteLine(ch + " is a SPECIAL SYMBOL");
            ExitLabel:
            Console.ReadKey();
        }
    }
}