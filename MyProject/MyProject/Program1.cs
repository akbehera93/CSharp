//convert case of character entered
using System;
namespace MyProject
{
    class Program1
    {
        static void Main(string[] args)
        {
            char ch;
            int a;
            Console.WriteLine("Enter a character between A to Z \n If you enter in lower case then we will return it's upper case character and vice versa");
            ch = Convert.ToChar(Console.Read());
            a = (int)ch;
            if (a >= 65 && a <= 90)
            {
                a += 32;
                ch = (char)a;
                Console.WriteLine("The required character is: " + ch);
            }
            else if (a >= 97 && a <= 122)
            {
                a -= 32;
                ch = (char)a;
                Console.WriteLine("The required character is: " + ch);
            }
            else
                Console.WriteLine("INVALID INPUT");
            Console.ReadKey();
        }
    }
}
