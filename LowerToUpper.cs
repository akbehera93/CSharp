using System;
namespace Practice
{
    public class LowerToUpper
    {//lower case to upper case
        public static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter a lower case character: ");
            ch=(char)Console.Read();
            LowerToUpper LTU=new LowerToUpper();
            Console.WriteLine(LTU.ChangeCase(ch));
        }
        public char ChangeCase(char ch)
        {
            ch=(char)((int)ch-32);
            return ch;
        }
    }
}