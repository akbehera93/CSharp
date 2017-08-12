using System;
namespace Practice
{
    public class AsciiValue
    {//determines the type of ASCII character
        public static void Main(string[] args)
        {
            Console.Write("Enter a Character: ");
            char ch=(char)Console.Read();
            AsciiValue AV=new AsciiValue();
            AV.CharacterType(ch);
        }
        public void CharacterType(char ch)
        {
            int chn=(int)ch;
            if(chn>=65 && chn<=90)
            {
                Console.WriteLine("{0} is upper case character",ch);
            }
            else if(chn>=97 && chn<=122)
            {
                Console.WriteLine("{0} is lower case character",ch);
            }
            else if(chn>=48 && chn<=57)
            {
                Console.WriteLine("{0} is a Numeric digit",ch);
            }
            else
            {
                Console.WriteLine("Sorry! I don't know the character type of {0}",ch);
            }
        }
    }
}